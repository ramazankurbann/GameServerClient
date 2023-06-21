using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entity;

namespace DataAccessLayer.Context
{
    public class SQLContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("server:DESKTOP-T0EH4JM;database:Game;");
        }

        public DbSet<DummyEntity> DummyEntities { get; set; }
    }
}
