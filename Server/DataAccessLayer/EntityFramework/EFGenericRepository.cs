using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;

namespace DataAccessLayer.Repository
{
    public class EFGenericRepository<EntityType> : IRepository<EntityType> where EntityType : AbstractEntity
    {
        private DbContext dbContext;

        public EFGenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Insert(EntityType entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(EntityType entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }
        public void Delete(EntityType entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public EntityType GetByID(int id)
        {
            return dbContext.Set<EntityType>().Find(id);
        }

        public List<EntityType> GetListAll()
        {
            return dbContext.Set<EntityType>().ToList();
        }
    }
}
