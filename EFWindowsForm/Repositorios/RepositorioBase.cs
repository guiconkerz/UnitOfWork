using EFWindowsForm.Data;
using EFWindowsForm.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFWindowsForm.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private DbSet<T> dbSet;

        public RepositorioBase(AppDbContext context, IUnitOfWork unitOfWork)
        {
            this._context = context;
            this._unitOfWork = unitOfWork;
            this.dbSet = _context.Set<T>();
        }
        
        public void Adicionar(T entity)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                dbSet.Add(entity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        public void Atualizar(T entity)
        {
            MessageBox.Show($"O item foi atualizado no repositorio base");
        }

        public void ObterPorId(int id)
        {
            MessageBox.Show($"O item foi listado no repositorio base");
        }

        public IEnumerable<T> ObterTodos(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Remover(T entity)
        {
            MessageBox.Show($"O item foi removido no repositorio base");
        }
    }
}
