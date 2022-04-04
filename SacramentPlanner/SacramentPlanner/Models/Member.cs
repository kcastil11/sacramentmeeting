using System.ComponentModel.DataAnnotations;

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
        [Display(Name ="Is Bishopric")]
        public bool IsBishopric { get; set; }
    }
}
