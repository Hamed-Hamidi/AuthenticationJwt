
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AuthenticationJwt.Common
{
    public class JwtAuthAttribute : AuthAttribute
    {
        public JwtAuthAttribute(string policy = "") : base(JwtBearerDefaults.AuthenticationScheme , policy)
        {
        }

    }
}