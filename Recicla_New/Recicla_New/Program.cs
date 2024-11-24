using ApplicationService.Application;
using ApplicationService.Interface;
using Infrastructure.Interface;
using Infrastructure.Repository;
using ServiceDomain.Interface;
using ServiceDomain.Service;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Infrastructure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Domain.AuthDTO;
//using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var config =  builder.Configuration;

//Autorização para requisição com o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins("*")
               .AllowAnyMethod()
               .AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddScoped<LoginValidator>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<IItemColetadoRepository, ItemColetadoRepository>();
builder.Services.AddScoped<IColetaRepository, ColetaRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IColetadorRepository, ColetadorRepository>();

//Dependency Injection Application
builder.Services.AddScoped<IUsuarioApplication, UsuarioApplication>();
builder.Services.AddScoped<IEstadoApplication, EstadoApplication>();
builder.Services.AddScoped<IItemColetadoApplication, ItemColetadoApplication>();
builder.Services.AddScoped<IColetaApplication, ColetaApplication>();
builder.Services.AddScoped<IVeiculoApplication, VeiculoApplication>();
builder.Services.AddScoped<IColetadorApplication, ColetadorApplication>();



//Dependency Injection Service
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IEstadoService, EstadoService>();
builder.Services.AddScoped<IItemColetadoService, ItemColetadoService>();
builder.Services.AddScoped<IColetaService, ColetaService>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddScoped<IColetadorService, ColetadorService>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = config["Jwt:Issuer"],
        ValidAudience = config["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]!)),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true

    };
});


////Dependency Injection SqlContext
builder.Services.AddScoped<SqlContext, SqlContext>();

//builder.Services.AddControllers().AddJsonOptions(x =>
//   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AdmMaster API",
        Version = $"v1",
        Description = "API para consumo de dados do Front em Vue"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"Autenticação por token JWT. Entre com o valor no formato: Bearer SEU_TOKEN",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });

}
);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

////Autorização para requisição CORs
//app.UseCors("corsapp");
//app.UseAuthorization();

//app.UseAuthentication();
//app.UseAuthorization();
app.UseCors("AllowSpecificOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
