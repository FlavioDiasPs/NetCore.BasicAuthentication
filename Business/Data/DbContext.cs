
using Authentication.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Authentication.Data
{
    public class DbContext : IdentityDbContext<BusinessUser>
    {
        public DbContext()
        {

        }

        public DbContext(DbContextOptions options)
            : base(options)
        {

        }    
    }
}
