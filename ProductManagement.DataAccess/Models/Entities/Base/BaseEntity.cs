using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.DataAccess.Models.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDateTimeUTC { get; set; }
    }
}
