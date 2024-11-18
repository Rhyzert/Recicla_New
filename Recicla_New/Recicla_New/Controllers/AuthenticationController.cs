using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Application.Controllers
{
    [Route("auth")]
    [AllowAnonymous]
    public class AuthenticationController
    {

    }
}
