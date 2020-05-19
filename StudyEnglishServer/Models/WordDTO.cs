using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Models.WordDTO
{
    /// <summary>
    /// Хранить параметры слова.
    /// </summary>
    public class WordDTO
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст слова.
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Перевод слова.
        /// </summary>
        public List<TranslateDTO> Translate { get; set; }
    
        /// <summary>
        /// Транскрипция.
        /// </summary>
        public string Transcription { get; set; }
    }
}
