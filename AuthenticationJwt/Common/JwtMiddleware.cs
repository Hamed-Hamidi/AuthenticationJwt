using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationJwt.Common
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IJwtHandler _jwtHandler;
        public JwtMiddleware(RequestDelegate next, IJwtHandler jwtHandler)
        {
            _next = next;
            _jwtHandler = jwtHandler;
        }

        public Task Invoke(HttpContext httpContext)
        {
            string authorization = httpContext.Request.Headers["Authorization"];
            if (authorization != null)
            {
                if (authorization.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                    authorization = authorization.Substring("Bearer ".Length).Trim();
                var objJsonWebTokenPayload = _jwtHandler.GetTokenPayload(authorization);

                //todo check any things ex role , user scope  
            }

            return _next(httpContext);
        }
    }

}
