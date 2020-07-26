using System.ComponentModel.DataAnnotations;

namespace Activities.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
