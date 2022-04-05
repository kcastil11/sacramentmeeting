using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        [NotMapped]
        public string Fullname => Firstname + " " + Surname;

        [Display(Name ="Is Bishopric")]
        public bool IsBishopric { get; set; }
    }
}
