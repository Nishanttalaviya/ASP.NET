using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace _6baspacore.Models
{
    public class Studentmodel
    {
        [Key]
        public int Id { get; set; }
        [Required,NotNull]

        public string Name { get; set; }
        [Required]
        public string Branch { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public int Phone { get; set; }

    }
}
