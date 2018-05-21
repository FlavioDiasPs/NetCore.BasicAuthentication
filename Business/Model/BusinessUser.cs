using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Model
{
    public class BusinessUser : IdentityUser
    {       
        public string LegalDocument { get; set; }

    }
}
