using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;
     

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
     
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastroUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastro(dto);
            return Ok("Usuário cadastro");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
        
       
    }
}
