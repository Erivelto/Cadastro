using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GerenciadorFC.Cadastro.Servicos.JwtModels
{
    public static class JwtSecurtyKey
    {
		public static SymmetricSecurityKey Create(string secret) =>
		   new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
	}
}
