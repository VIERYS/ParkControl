using System.ComponentModel.DataAnnotations;

namespace ParkControl.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La placa es obligatoria")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "El tipo de vehículo es obligatorio")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El propietario es obligatorio")]
        public string Propietario { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        public string Telefono { get; set; }
    }
}