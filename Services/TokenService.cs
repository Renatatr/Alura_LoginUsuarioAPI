using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UsuarioAPI.Models;

namespace UsuarioAPI.Services;

public class TokenService
{
    public string GenerateToken(Usuario usuario)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username", usuario.UserName),
            new Claim("id", usuario.Id),
            new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString()),
            new Claim("loginTimestamp", DateTime.UtcNow.ToString()),
        };

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("324J3R09EOIRJWE09R23T5T4RHG45H"));
        var signingCredetials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken
        (
            expires: DateTime.Now.AddMinutes(2),
            claims: claims,
            signingCredentials: signingCredetials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
