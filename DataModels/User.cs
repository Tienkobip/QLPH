using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
        [Phone]
        [StringLength(15)]
        public string Phone { get; set; }

    }
}
