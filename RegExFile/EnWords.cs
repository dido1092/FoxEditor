using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExFile
{
    public class EnWords
    {
        public EnWords()
        {
               
        }
        [Key]
        public int? Id { get; set; }

        [Required]
        public string EnWord { get; set; }

        [Required]
        public int? Length { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
