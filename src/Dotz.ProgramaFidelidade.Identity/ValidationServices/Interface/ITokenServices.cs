using System.Collections.Generic;
using System.Security.Claims;

namespace Dotz.ProgramaFidelidade.Identity.ValidationServices.Interface
{
    public interface ITokenServices
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
