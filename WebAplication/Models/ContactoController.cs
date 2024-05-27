using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        public String Telefono { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        public string  Email { get; set; }
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage ="Estado civil obligatorio")]
        public DateTime FechaCreacion { get; set; }
        [DataType(DataType.Date)]
        public DateTime  FechaNacimiento { get; set; }
         public byte[] Foto { get; set; }
    }
}