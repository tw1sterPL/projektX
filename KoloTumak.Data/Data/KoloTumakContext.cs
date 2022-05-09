using KoloTumak.Data.Data.CMS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloTumak.Data.Data
{
    public class KoloTumakContext: DbContext
    {
        public KoloTumakContext(DbContextOptions<KoloTumakContext> options)
            : base(options)
        {
        }

        public DbSet<Main> Main { get; set; }

        public DbSet<EventsAllUser> EventsAllUser { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<HuntersList> HuntersList { get; set; }

        public DbSet<HuntingBook> HuntingBook { get; set; }

        public DbSet<About> About { get; set; }

        public DbSet<Management> Management { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<EditWWW> EditWWW { get; set; }

        public DbSet<HeaderSiteName> HeaderSiteName { get; set; }

    }
}
