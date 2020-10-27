using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public class JournalEntry
    {
        public int ID { get; set; }
        
        [Display(Name ="Entry Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EntryDate { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Range(1, 100)]
        public int Chapter { get; set; }

        [Range(1, 200)]
        [Required]
        public int Verse { get; set; }
        public string Scripture { get; set; }
        public string Entry { get; set; }
    }
}
