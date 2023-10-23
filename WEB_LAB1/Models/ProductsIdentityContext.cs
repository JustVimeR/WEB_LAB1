using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WEB_LAB1.Models
{
    public class ProductsIdentityContext : IdentityDbContext<IdentityUser>
    {
        public ProductsIdentityContext(DbContextOptions<ProductsIdentityContext> options) : base(options) { Database.EnsureCreated(); }
    }
}
