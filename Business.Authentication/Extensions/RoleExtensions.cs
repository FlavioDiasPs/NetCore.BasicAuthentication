using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Extensions
{
    public enum Role
    {
        Admin,
        Role1,
        Role2
    }

    public static class RoleExtensions
    {
        public static string GetRoleName(this Role role) // convenience method
        {
            return role.ToString();
        }
    }
}
