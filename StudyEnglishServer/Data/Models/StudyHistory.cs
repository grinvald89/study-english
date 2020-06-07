using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Models
{
    /// <summary>
    /// Хранит историю изучения слова
    /// </summary>
    public class StudyHistory
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// True, если ответ был правильный
        /// </summary>
        public bool Correct { get; set; }
        /// <summary>
        /// Дата ответа
        /// </summary>
        public DateTime Data { get; set; }
    }
}
