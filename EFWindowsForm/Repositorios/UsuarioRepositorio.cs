using EFWindowsForm.Data;
using EFWindowsForm.Interfaces;
using EFWindowsForm.Models;
using Microsoft.EntityFrameworkCore;

namespace EFWindowsForm.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _context;
        private readonly RepositorioBase<UsuarioModel> _repositorioBase;
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioRepositorio(AppDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _repositorioBase = new RepositorioBase<UsuarioModel>(context, unitOfWork);
        }


        public void Adicionar(UsuarioModel usuario)
        {
            try
            {
                _context.Usuario.FromSqlRaw("");
                _unitOfWork.BeginTransaction();
                _repositorioBase.Adicionar(usuario);
                _unitOfWork.Commit();
                MessageBox.Show($"{usuario.Usuario} Adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                MessageBox.Show($"Erro de exceção: {ex.Message}");
                throw;
            }
        }

        public void PesquisarUsuario(string nomeUsuario)
        {
            try
            {
                List<UsuarioModel> usuariosEncontrados = _context.Usuario.Where(x => x.Usuario.Contains(nomeUsuario)).ToList(); ;

                if (usuariosEncontrados.Count > 0)
                {
                    string mensagem = "Usuários encontrados:\n";
                    foreach (UsuarioModel usuario in usuariosEncontrados)
                    {
                        mensagem += $"Id: {usuario.IdUsuario}\n" +
                                    $"Usuário: {usuario.Usuario}\n" +
                                    $"Senha: {usuario.Senha}\n" +
                                    $"Nível de Acesso: {usuario.NivelAcesso}\n\n";
                    }

                    MessageBox.Show(mensagem);
                }
                else
                {
                    MessageBox.Show("Nenhum usuário encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
