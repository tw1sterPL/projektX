using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data
{
    internal class KoloTumakContextFactory : IDesignTimeDbContextFactory<KoloTumakContext>
    {
        public KoloTumakContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KoloTumakContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KoloTumakContext;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new KoloTumakContext(optionsBuilder.Options);
        }
    }
}
