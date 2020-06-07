using StudyEnglishServer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Models
{
    /// <summary>
    /// Хранит параметры слова.
    /// </summary>
    public class Word
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст слова.
        /// </summary>
        public string Text{ get; set; }

        /// <summary>
        /// Перевод слова.
        /// </summary>
        public List<Translate> Translate { get; set; }
    
        /// <summary>
        /// Транскрипция.
        /// </summary>
        public string Transcription { get; set; }

        /// <summary>
        /// Ассоциация.
        /// </summary>
        public string Association { get; set; }

        /// <summary>
        /// Ссылки на audio-файлы.
        /// </summary>
        public List<Audio> Audio { get; set; }

        /// <summary>
        /// Статистика по изучению слова
        /// </summary>
        public Statistics Statistics { get; set; }

        /// <summary>
        /// История изучения слова
        /// </summary>
        public StudyHistory[] StudyHistory { get; set; }
    }
}
