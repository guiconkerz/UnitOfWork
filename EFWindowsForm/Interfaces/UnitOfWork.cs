using EFWindowsForm.Data;
using EFWindowsForm.Models;
using EFWindowsForm.Repositorios;
using Microsoft.EntityFrameworkCore.Storage;

namespace EFWindowsForm.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }
        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
        }
    }
}
