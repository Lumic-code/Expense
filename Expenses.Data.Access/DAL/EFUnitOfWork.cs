using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Access.DAL
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private  DbContext _context;

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbContext Context => _context;

        public void Add<T>(T entity) where T : class
        {
            var set = _context.Set<T>();
            set.Add(entity);
        }

        public void Attach<T>(T entity) where T : class
        {
            var set = _context.Set<T>();
            set.Attach(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context = null;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Remove<T>(T entity) where T : class
        {
            var set = _context.Set<T>();
            set.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            var set = _context.Set<T>();
            set.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        ITransaction IUnitOfWork.BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Snapshot)
        {
            return new DbTransaction(_context.Database.BeginTransaction(isolationLevel));
        }

        
    }
}
