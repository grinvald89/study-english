using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Models
{
    /// <summary>
    /// Хранит статистику по изучению слова
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Количество показов
        /// </summary>
        public int CountShow { get; set; }
        /// <summary>
        /// Процент правильных ответов
        /// </summary>
        public float Correctness { get; set; }
        /// <summary>
        /// Дата последнего показа
        /// </summary>
        public DateTime DateLastShow { get; set; }
    }
}
