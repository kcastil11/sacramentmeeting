using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models.ViewModel
{
    public class ProgramViewModel
    {
        [Display(Name="Opening Hymn")]
        [Required]
        public string OpeningSong { get; set; }


        [Display(Name = "Sacrament Hymn")]
        [Required]
        public string SacramentHymn { get; set; }


        [Display(Name = "Closing Hymn")]
        [Required]
        public string ClosingSong { get; set; }


        [NotMapped]
        public Member ConductingLeader { get; set; }

        [Display(Name = "Conductor")]
        [Required]
        public string ConductingLeaderId { get; set; }


        [Display(Name = "Intermediate Hymn")]
        public string MusicalNumber { get; set; }


        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }


        [Display(Name = "Cloosing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }


        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ProgramDate { get; set; }


        [Display(Name = "Speakers")]
        public List<SpeakerSubject> Speakers { get; set; }

    }
}
