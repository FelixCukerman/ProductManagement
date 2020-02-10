using ProductManagement.DataAccess.Models.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.DataAccess.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
