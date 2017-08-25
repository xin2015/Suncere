using System.Linq;
using Suncere.EntityFramework;
using Suncere.MultiTenancy;

namespace Suncere.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SuncereDbContext _context;

        public DefaultTenantCreator(SuncereDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
