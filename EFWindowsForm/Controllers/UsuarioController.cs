using EFWindowsForm.Data;
using EFWindowsForm.Interfaces;
using EFWindowsForm.Models;

namespace EFWindowsForm.Controllers
{
    public class UsuarioController 
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public void AdicionarUsuario(UsuarioModel usuarioModel)
        {
            _usuarioRepositorio.Adicionar(usuarioModel);
        }
        public void PesquisarUsuario(string nomeUsuario)
        {
            _usuarioRepositorio.PesquisarUsuario(nomeUsuario);
        }
    }
}
