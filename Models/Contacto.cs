using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El telefono fijo es obligatorio")]
        public string TelefonoFijo { get; set; }

        [Required(ErrorMessage = "El telefono movil es obligatorio")]
        public string TelefonoMovil { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }



    }
}
