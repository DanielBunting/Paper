using Microsoft.IdentityModel.Tokens;
using Paper.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Paper
{
    public class TokenService : ITokenService
    {
        private readonly JWTConfig _jwtConfig;

        public TokenService(JWTConfig jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }

        public string GenerateToken(string userId)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            // Add other claims as needed
        };

            var token = new JwtSecurityToken(
            issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
            claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtConfig.Expires),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool Validate(string token, out string UserId)
        {
            throw new NotImplementedException();
        }

        public static (string EmailAddress, string AppleSubId) GetAppleClaims(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            var sub = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "sub")?.Value;
            var email = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "email")?.Value;

            foreach (var claim in jwtSecurityToken.Claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }

            return (email, sub);
        }

    }
}
