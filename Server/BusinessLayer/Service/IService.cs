using DTOLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public interface IService
    {
        public AbstractDTO Get(int id);
        public void Post(AbstractDTO dto);
        public void Put(int id, AbstractDTO dto);
        public void Delete(int id);
      
    }
}
