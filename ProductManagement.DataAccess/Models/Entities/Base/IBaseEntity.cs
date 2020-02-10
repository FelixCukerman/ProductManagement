using System;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.DataAccess.Models.Entities.Base
{
    public interface IBaseEntity
    {
        [Key]
        int Id { get; set; }
        DateTime CreationDateTimeUTC { get; set; }
    }
}
