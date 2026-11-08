using System.ComponentModel.DataAnnotations;

namespace cibertec_demo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Display(Name = ")]


        public string nombre { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El correo no puede superar los 50 caracteres")]
        [EmailAddress(ErrorMessage = "Correo electrónico inválido")]
        [Display(Name = "Correo Electrónico")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatoria")]
        [StringLength(50, MininumLength = 4, ErrorMessage = "La contraseña no puede superar los 50 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Fecha de registro")]
        public string clave { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime fechaRegistro { get; set; }
    }
}
