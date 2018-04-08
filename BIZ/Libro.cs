using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class Libro
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String ISBN { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Titulo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GeneroId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AutorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EditorialId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Imagen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Cantidad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Destacado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CreatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ChangedOn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ChangedBy { get; set; }
    }
}
