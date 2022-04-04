using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{

    public class History
    {
        [Key]
        public int Id { get; set; }
        public string SpeakerSubjects { get; set; }
        public DateTime HistoryDate { get; set; }

    }
}