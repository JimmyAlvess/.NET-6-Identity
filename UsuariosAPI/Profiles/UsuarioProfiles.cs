using AutoMapper;
using UsuariosAPI.Data.Dtos;
using UsuariosAPI.Models;

namespace UsuariosAPI.Profiles
{
    public class UsuarioProfiles : Profile
    {
        public UsuarioProfiles()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
