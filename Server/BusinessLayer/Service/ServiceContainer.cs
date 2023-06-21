using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using DTOLib;
using DTOLib.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public enum ServiceEnum
    {
        Dummy,
    }

    public class ServiceContainer
    {
        private static ServiceContainer serviceFacade = null;

        DbContext dbContext;
        IDummyRepository dummyRepository;

        IService[] serviceList;

        private ServiceContainer()
        {
            dbContext = new SQLContext();
            dummyRepository = new EFDummyRepository(dbContext);

            serviceList = new IService[Enum.GetNames(typeof(ServiceEnum)).Length];

            serviceList[(int)ServiceEnum.Dummy] = new DummyService(dummyRepository);
        }

        public static ServiceContainer Instance()
        {
            if(serviceFacade == null)
            {
                serviceFacade = new ServiceContainer();
            }

            return serviceFacade;
        }

        public IService GetService(ServiceEnum serviceEnum)
        {
            return serviceList[(int)serviceEnum];
        }
    }
}
