using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplierApplication.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Supplier Name")]
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }
    }
}
