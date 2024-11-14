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
using Microsoft.AspNetCore.DataProtection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Autorização para requisição com o CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins("*")
               .AllowAnyMethod()
               .AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IItemColetadoRepository, ItemColetadoRepository>();
builder.Services.AddScoped<IColetaRepository, ColetaRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IColetadorRepository, ColetadorRepository>();

//Dependency Injection Application
builder.Services.AddScoped<IUsuarioApplication, UsuarioApplication>();
builder.Services.AddScoped<IItemColetadoApplication, ItemColetadoApplication>();
builder.Services.AddScoped<IColetaApplication, ColetaApplication>();
builder.Services.AddScoped<IVeiculoApplication, VeiculoApplication>();
builder.Services.AddScoped<IColetadorApplication, ColetadorApplication>();



//Dependency Injection Service
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IItemColetadoService, ItemColetadoService>();
builder.Services.AddScoped<IColetaService, ColetaService>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddScoped<IColetadorService, ColetadorService>();



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

/*
const string AuthScheme = "cookie"
builder.Services.AddAuthentication("cookie")
    .AddCookie("cookie");*/
var app = builder.Build();


/*app.UseAuthentication();

app.MapGet("/username", (HttpContext ctx) =>
{
    return ctx.User.FindFirst("usr").Value;

});

app.MapGet("/login", async (HttpContext ctx) =>
{
    *//*auth.SignIn();*//*
    var claims = new List<Claim>();
    claims.Add(new Claim("usr","anton"));
    var identity = new ClaimsIdentity(claims, "cookie");
    var user = new ClaimsPrincipal(identity);


    await ctx.SignInAsync("cookie",user);
    return "ok";
});*/

/*public class AuthService
{
    private readonly IDataProtectionProvider _idp;
    private readonly IHttpContextAccessor _accessor;

    public AuthService(IDataProtectionProvider idp, IHttpContextAccessor accessor)
    {
        _idp = idp;
        _accessor = accessor;
    }

    public void SignIn()
    {
        var protector = _idp.CreateProtector("auth-cookie");
        _accessor.HttpContext.Response.Headers["set-cookie"] = $"auth={protector.Protect("usr:anton")}";
    }
};
*/
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
