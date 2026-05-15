using System.ComponentModel.DataAnnotations;

namespace a14468_employes_management.Models
{
    public class Instrument
    {
        public int Id { get; set; }

        [Required]
        public string TipoInstrumento { get; set; }

        [Required]
        public string NomeInstrumento { get; set; }

        public bool UsaCordas { get; set; }
    }
}