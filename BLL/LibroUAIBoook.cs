using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LibroUAIBoook
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<BIZ.Libro> ListarTodosLosLibros()
        {
            var lista = new DAL.Facade.LibroFacade().SeleccionarLibrosTodos();
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public BIZ.Libro ObtenerLibro(Int32 id)
        {
            var libro = new DAL.Facade.LibroFacade().ObtenerUnLibro(id);
            return libro;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void CrearLibro(BIZ.Libro libro)
        {
            new DAL.Facade.LibroFacade().CrearLibro(libro);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void ActualizarLibro(BIZ.Libro libro)
        {
            new DAL.Facade.LibroFacade().ActualizarLibro(libro);
        }

    }
}
