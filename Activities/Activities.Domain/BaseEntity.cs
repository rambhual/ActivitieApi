using System;
using System.ComponentModel.DataAnnotations;

namespace Activities.Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
