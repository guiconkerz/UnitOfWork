using EFWindowsForm.Controllers;
using EFWindowsForm.Models;

namespace EFWindowsForm
{
    public partial class Form1 : Form
    {
        private readonly UsuarioController _usuarioController;
        public Form1(UsuarioController usuarioController)
        {
            _usuarioController = usuarioController;
            InitializeComponent();
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            _usuarioController.PesquisarUsuario(txtPesquisa.Text);
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel = new UsuarioModel()
            {
                Usuario = "Teste 7 UnitOfWork",
                Senha = "1234",
                NivelAcesso = "Admin"
            };
            _usuarioController.AdicionarUsuario(usuarioModel: usuarioModel);
        }
        
    }
}