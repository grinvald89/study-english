using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishServer.Data.Models
{
    public class Audio
    {
        /// <summary>
        /// Идентификатор файла
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Url файла
        /// </summary>
        public string Url { get; set; }
    }
}
