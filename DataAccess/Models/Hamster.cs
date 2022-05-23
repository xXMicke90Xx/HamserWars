using System.ComponentModel.DataAnnotations;

namespace HamserWarsApi.Models
{
    public class Hamster
    {
        public int id { get; set; }

        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public int Age { get; set; } = 0;
        [Required]
        public string FavFood { get; set; } = String.Empty;
        [Required]
        public string Loves { get; set; } = String.Empty;
        [Required]
        public string ImgName { get; set; } = String.Empty;
        [Required]
        public int Wins { get; set; } = 0;
        [Required]
        public int Losses { get; set; } = 0;
        [Required]
        public int Games { get; set; } = 0;

    }
}
