using System.ComponentModel.DataAnnotations;

namespace ContactManagement.Models
{
    public class Phones
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string firstName { get; set; }
        [Required]
        [StringLength(50)]
        public string lastName { get; set; }
        [StringLength(250)]
        public string? email { get; set; }
        [Required]
        [StringLength(10)]
        public string phoneNumber { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
