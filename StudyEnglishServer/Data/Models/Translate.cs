using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Models
{
    /// <summary>
    /// Хранит перевод слова.
    /// </summary>
    public class Translate
    {
        /// <summary>
        /// Идентификатор перевода.
        /// </summary>
        public int Id { get; set; }

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
