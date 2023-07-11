using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWindowsForm.Models
{
    public class UsuarioModel
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string NivelAcesso { get; set; }
    }
}
