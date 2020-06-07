using Microsoft.EntityFrameworkCore;
using StudyEnglishServer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Repository
{
    public class WordRepository
    {
        private readonly StudyEnglishDBContext dbContext;

        public WordRepository(StudyEnglishDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Word> Words =>
                dbContext.Words
                    .Include(c => c.Audio)
                    .Include(c => c.Translate)
                    .Include(c => c.Statistics)
                    .Include(c => c.StudyHistory);
        public IEnumerable<Translate> Translates => dbContext.Translates;
        public IEnumerable<Audio> Audio => dbContext.Audio;
        public IEnumerable<Statistics> Statistics => dbContext.Statistics;
        public IEnumerable<StudyHistory> StudyHistory => dbContext.StudyHistory;
    }
}
