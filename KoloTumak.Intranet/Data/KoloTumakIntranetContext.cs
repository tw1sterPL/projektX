#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoloTumak.Intranet.Models.CMS;

namespace KoloTumak.Intranet.Data
{
    public class KoloTumakIntranetContext : DbContext
    {
        public KoloTumakIntranetContext (DbContextOptions<KoloTumakIntranetContext> options)
            : base(options)
        {
        }

        public DbSet<KoloTumak.Intranet.Models.CMS.Main> Main { get; set; }

        public DbSet<KoloTumak.Intranet.Models.CMS.EventsAllUser> EventsAllUser { get; set; }

        public DbSet<KoloTumak.Intranet.Models.CMS.News> News { get; set; }

        public DbSet<KoloTumak.Intranet.Models.CMS.HuntersList> HuntersList { get; set; }
    }
}
