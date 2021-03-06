using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class SacramentProgram
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Opening Hymn")]
        public string OpeningSong { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]

        public string ClosingSong { get; set; }

        public int ConductingLeaderId { get; set; }

        [Display(Name = "Intermediate Hymn")]

        public string MusicalNumber { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }


        [Required]
        [Display(Name = "Closing Prayer")]

        public string ClosingPrayer { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ProgramDate { get; set; }

       
    }
}