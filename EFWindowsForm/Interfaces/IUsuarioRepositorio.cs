using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWindowsForm.Models;

namespace EFWindowsForm.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void Adicionar(UsuarioModel usuario);
        void PesquisarUsuario(string nomeUsuario);
    }
}
