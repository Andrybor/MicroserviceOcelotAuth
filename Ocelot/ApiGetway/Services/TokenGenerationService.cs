using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ApiGetway.Constants;
using Microsoft.IdentityModel.Tokens;

namespace ApiGetway.Services;

public class TokenGenerationService : ITokenGenerationService
{
    public string GenerateToken(string userName)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, userName)
        };

        var jwt = new JwtSecurityToken(
            issuer: Authentication.Issuer,
            audience: Authentication.Audience,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(Authentication.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
    
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}