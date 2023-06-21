using DTOLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using EntityLayer.Entity;

namespace BusinessLayer.Service
{
    public abstract class ServiceBase : IService 
    {   
        public abstract void Delete(int id);
        public abstract AbstractDTO Get(int id);
        public abstract void Post(AbstractDTO dto);
        public abstract void Put(int id, AbstractDTO dto);
    }
}
