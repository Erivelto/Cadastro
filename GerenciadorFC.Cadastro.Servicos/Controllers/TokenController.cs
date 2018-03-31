using GerenciadorFC.Cadastro.Servicos.JwtModels;
using GerenciadorFC.Cadastro.Servicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/Token")]
    public class TokenController : Controller
    {
		[HttpPost]
		public IActionResult Post([FromBody]LoginModel loginModel)
		{
			if (loginModel.Username != "fabio" && loginModel.Password != "erivelto33")
				return Unauthorized();

			var token = new JwtTokenBuilder()
								.AddSecurityKey(JwtSecurtyKey.Create("a-password-very-big-to-be-good"))
								.AddSubject("Fabio Erivelto")
								.AddIssuer("http://localhost:12796")
								.AddAudience("http://localhost:12796")
								.AddNameId("fabioesimoes@gmail.com")
								.AddClaim("employeer", "31")
								.AddExpiry(1)
								.Build();

			return Ok(token);
		}
	}
}