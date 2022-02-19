using Microsoft.EntityFrameworkCore;
using SupplierApplication.Models;

namespace SupplierApplication.Persistance
{
    public class SupplierDbContex : DbContext
    {
        public SupplierDbContex(DbContextOptions<SupplierDbContex> options) : base(options)
        {
        }
        public DbSet<Supplier> GetSuppliers { get; set; }
    }
}
