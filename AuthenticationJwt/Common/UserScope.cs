using System;
using System.Collections.Generic;

namespace AuthenticationJwt.Common
{
    public class UserScope
    {
        public List<Guid> roleIds { get; }

        private UserScope()
        {

        }
        public UserScope(List<Guid> roleIds)
        {
            this.roleIds = roleIds;
        }

       
    }
}
