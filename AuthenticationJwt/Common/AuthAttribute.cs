using Microsoft.AspNetCore.Authorization;

namespace AuthenticationJwt.Common
{
    public class AuthAttribute : AuthorizeAttribute
    {
        public AuthAttribute(string scheme, string policy = "") : base(policy)
        {
            AuthenticationSchemes = scheme;
        }

    }
}