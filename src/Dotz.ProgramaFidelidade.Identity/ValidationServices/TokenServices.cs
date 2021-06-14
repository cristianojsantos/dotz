using Dotz.ProgramaFidelidade.Identity.ValidationServices.Interface;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Dotz.ProgramaFidelidade.Identity.ValidationServices
{
    public class TokenServices : ITokenServices
    {
        private TokenConfiguration _configurations;

        public TokenServices(TokenConfiguration configuration)
        {
            _configurations = configuration;
        }

        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configurations.Secret));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var options = new JwtSecurityToken(
                issuer: _configurations.Issuer,
                audience: _configurations.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_configurations.Minutes),
                signingCredentials: signinCredentials);

            return new JwtSecurityTokenHandler().WriteToken(options);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidatorsParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configurations.Secret)),
                ValidateLifetime = false
            };

            var tokenHadler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;

            ClaimsPrincipal principal = tokenHadler.ValidateToken(token, tokenValidatorsParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;

            if (jwtSecurityToken == null || 
                !jwtSecurityToken.Header.Alg.Equals(
                    SecurityAlgorithms.HmacSha256, 
                    StringComparison.InvariantCulture)) throw new SecurityTokenException("Token inválido");

            return principal;
        }
    }
}
