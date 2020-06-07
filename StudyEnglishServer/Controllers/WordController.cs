using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyEnglishServer.Data;
using System.Data;
using Microsoft.EntityFrameworkCore;
using StudyEnglishServer.Data.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StudyEnglishServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        StudyEnglishDBContext db;

        Random random = new Random();

        List<Word> words;

        public WordController()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("dbsettings.json");

            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<StudyEnglishDBContext>();

            var options = optionsBuilder
                .UseSqlServer(config.GetConnectionString("DefaultConnection"))
                .Options;

            db = new StudyEnglishDBContext(options);

            db.Words.Load();
            db.Audio.Load();
            db.Translates.Load();

            words = db.Words.ToList();
        }

        // GET api/word
        [HttpGet]
        public ActionResult<Word> Get()
        {
            /*

            Word newWord = new Word();

            newWord.Text = "hello";
            newWord.Transcription = "heˈlō,həˈlō";

            db.Words.Add(newWord);
            db.SaveChanges();
            */

            int index = random.Next(0, words.Count - 1);

            return words.ElementAt(index);
        }

        // GET api/word/5
        [HttpGet("{id}")]
        public ActionResult<string> GetRandom()
        {
            return "value";
        }

        // POST api/word
        [HttpPost]
        public Word Post(Word word)
        {
            word.Id = 0;
            db.Words.Add(word);
            db.SaveChanges();

            return word;
        }

        // PUT api/word/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/word/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
