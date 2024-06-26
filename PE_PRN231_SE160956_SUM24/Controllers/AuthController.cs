﻿/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YourProjectRepository;
using YourProjectRepository.Token;

namespace WebAPI.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class MemberAccountController : ControllerBase
    {
        IMemberAccountRepo _user;
        IConfiguration _config;
        public MemberAccountController(IMemberAccountRepo user, IConfiguration config)
        {
            _user = user;
            _config = config ?? throw new ArgumentNullException(nameof(config));
            ProvideToken.Initialize(_config);
        }
        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {

            var checkLogin = _user.Login(email, password);
            if (checkLogin != null)
            {
                var token = ProvideToken.Instance.GenerateToken(checkLogin);
                return Ok(token);
            }
            return Unauthorized("Email or password wrong, please try login!");
        }
    }
}
*/