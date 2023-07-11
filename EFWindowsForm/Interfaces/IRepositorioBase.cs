using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFWindowsForm.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        void Adicionar(T entity);
        void Remover(T entity);
        void Atualizar(T entity);
        void ObterPorId(int id);
        IEnumerable<T> ObterTodos(Expression<Func<T, bool>> predicate = null);
    }
}
