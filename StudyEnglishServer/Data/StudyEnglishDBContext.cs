using Microsoft.EntityFrameworkCore;
using StudyEnglishServer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data
{
    public class StudyEnglishDBContext : DbContext
    {
        public StudyEnglishDBContext(DbContextOptions<StudyEnglishDBContext> options) : base(options) { }

        public DbSet<Word> Words { get; set; }
        public DbSet<Translate> Translates { get; set; }
        public DbSet<Audio> Audio { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<StudyHistory> StudyHistory { get; set; }
    }
}
