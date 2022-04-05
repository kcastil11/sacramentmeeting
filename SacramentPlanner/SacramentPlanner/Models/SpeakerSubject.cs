using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SpeakerSubject
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
    }
}
