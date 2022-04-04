using System;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public class Program
    {
        public int ID { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingSong { get; set; }
        public string ConductingLeader { get; set; }
        public string MusicalNumber { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public DateTime ProgramDate { get; set; }

        public ICollection<History> History { get; set; }
    }
}