using ApplicationService.Common.Common;
using ApplicationService.Common.Interfaces.Authentication;
using ApplicationService.RegisterLogin;
using Mapster;
using Microsoft.AspNetCore.Identity.Data;

namespace Application.Common.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ApplicationService.Common.Common.RegisterRequest, RegisterCommand>();

            config.NewConfig<ApplicationService.Common.Common.LoginRequest, LoginQuery>();

            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest.Id, src => src.usuario.Id.ToString())
                .Map(dest => dest, src => src.usuario);
        }
    }
}
