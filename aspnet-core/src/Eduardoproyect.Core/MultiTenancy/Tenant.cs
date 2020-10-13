﻿using Abp.MultiTenancy;
using Eduardoproyect.Authorization.Users;

namespace Eduardoproyect.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
