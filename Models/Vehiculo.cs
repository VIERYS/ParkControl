using System.ComponentModel.DataAnnotations;

namespace ParkControl.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La placa es obligatoria")]
        public string Placa { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Propietario { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}