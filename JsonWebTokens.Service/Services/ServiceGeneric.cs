using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonWebTokens.Service.Services
{
    static class ServiceGeneric
    {
        public static SecurityKey GetSymmetricSecurityKey(string securitykey) 
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securitykey));
        }
    }
}
