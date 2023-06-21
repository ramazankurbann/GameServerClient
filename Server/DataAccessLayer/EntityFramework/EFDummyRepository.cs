using DataAccessLayer.Repository;
using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFDummyRepository : EFGenericRepository<DummyEntity>, IDummyRepository
    {
        public EFDummyRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
