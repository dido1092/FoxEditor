using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExFile
{
    public class EnWordsTranscript
    {
        public EnWordsTranscript()
        {
               
        }

        [Key]
        public int? Id { get; set; }

        [Required]
        public string EnWord { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        [Required]
        public int? Length { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
