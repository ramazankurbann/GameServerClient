using DataAccessLayer.Repository;
using DTOLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    internal class DummyService : ServiceBase
    {

        IDummyRepository dummyRepository;

        public DummyService(IDummyRepository dummyRepository)
        {
            this.dummyRepository = dummyRepository;
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override AbstractDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public override void Post(AbstractDTO dto)
        {
            throw new NotImplementedException();
        }

        public override void Put(int id, AbstractDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
