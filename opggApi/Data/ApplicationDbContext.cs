using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opggApi.Models;

namespace opggApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<MatchLoL> Matches { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<RuneModel> Runes { get; set; }
    }
}
