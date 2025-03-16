using System.ComponentModel.DataAnnotations;

namespace SpellLista.Models
{
    public class Spel
    {
        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Kategori { get; set; }

        [Range(1, 10)]
        public int Betyg { get; set; }

        public string Beskrivning { get; set; }

        public string BildUrl { get; set; }

        public string TrailerUrl { get; set; }
    }
}
