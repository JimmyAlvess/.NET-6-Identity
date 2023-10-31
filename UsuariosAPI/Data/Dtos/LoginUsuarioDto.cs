using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace UsuariosAPI.Data.Dtos
{
    public class LoginUsuarioDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
