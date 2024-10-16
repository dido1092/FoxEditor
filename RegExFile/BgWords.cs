using System;
using System.ComponentModel.DataAnnotations;

namespace RegExFile
{
    public class BgWords
    {
        public BgWords()
        {

        }

        [Key]
        public int? Id { get; set; }

        [Required]
        public string BgWord { get; set; }

        [Required]
        public int? Length { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
