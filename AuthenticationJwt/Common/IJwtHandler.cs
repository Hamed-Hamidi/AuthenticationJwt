using System.Collections.Generic;

namespace AuthenticationJwt.Common
{
    public interface IJwtHandler
    {
        JsonWebToken CreateToken(string userId, string role, IDictionary<string, string> claims = null , UserScope userScope = null);

        JsonWebTokenPayload GetTokenPayload(string accessToken);
    }
}