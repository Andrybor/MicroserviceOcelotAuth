using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ApiGetway.Constants
{
    public static class Authentication
    {
        public static string Issuer = "MyAuthServer";
        public const string Audience = "MyAuthClient";
        const string Key = "mysupersecret_secretkey!123"; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
    }
}