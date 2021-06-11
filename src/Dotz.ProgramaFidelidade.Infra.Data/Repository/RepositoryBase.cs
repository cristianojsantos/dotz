using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable where TEntity : class
    {
        protected readonly DotzContext db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(DotzContext _db)
        {
            db = _db;
            DbSet = db.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            try
            {
                DbSet.Add(obj);
                db.SaveChanges();
                Dispose();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await Task.FromResult(DbSet.ToList<TEntity>());
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Task.FromResult(DbSet.Find(id));
        }

        public async void Remove(int id)
        {
            var obj = await GetById(id);
            DbSet.Remove(obj);
            db.SaveChanges();
            Dispose();
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
            db.SaveChanges();
            Dispose();
        }
    }
}