using System.ComponentModel.DataAnnotations;

namespace RegExFile.Data.Models
{
    public class BgWords
    {
        public BgWords()
        {

        }

        [Key]
        public int? Id { get; set; }

        [Required]
        public string? BgWord { get; set; }

        [Required]
        public int? Length { get; set; }
    }
}
