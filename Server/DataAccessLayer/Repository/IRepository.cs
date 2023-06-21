using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;


namespace DataAccessLayer.Repository
{
    public interface IRepository <EntityType> where EntityType : AbstractEntity 
    {
        public void Insert(EntityType entity);
        public void Delete(EntityType entity);
        public void Update(EntityType entity);
        public EntityType GetByID(int id);
        public List<EntityType> GetListAll();
    }
}
