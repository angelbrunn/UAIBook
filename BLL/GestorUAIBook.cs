using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorUAIBook
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<BIZ.Genero> ListarTodosLosGeneros()
        {
            var lista = new DAL.Facade.GeneroFacade().SeleccionarGenerosTodos();
            return lista;
        }
    }
}
