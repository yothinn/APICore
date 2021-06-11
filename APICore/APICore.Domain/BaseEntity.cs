using System.ComponentModel.DataAnnotations;

namespace APICore.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
