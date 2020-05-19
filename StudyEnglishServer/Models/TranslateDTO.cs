using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Models
{
    /// <summary>
    /// Хранит перевод слова.
    /// </summary>
    public class TranslateDTO
    {
        /// <summary>
        /// Идентификатор перевода.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор слова.
        /// </summary>
        public int WordId { get; set; }

        /// <summary>
        /// Текст перевода.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// True, если это основное значение (перевод) слова.
        /// </summary>
        public bool IsPrimary { get; set; }
    }
}
