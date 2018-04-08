using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Facade
{
    public class GeneroFacade
    {
        /// <summary>
        /// http://converter.telerik.com/
        /// </summary>
        /// <returns></returns>
        public List<BIZ.Genero> SeleccionarGenerosTodos()
        {
            List<BIZ.Genero> lista = new List<BIZ.Genero>();
            BIZ.Genero genero;
            //Crear una  lista Vacia
            //Crear un protoriopo Genero Vacio
            var dt = DAL.GTW.GeneroGateway.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                genero = new BIZ.Genero();
                genero.Id = (System.Int32)row["Id"];
                genero.Nombre = (System.String)row["Nombre"];
                genero.CreatedOn = (System.DateTime)row["CreatedOn"];
                genero.CreatedBy = (System.Int32)row["CreatedBy"];
                //genero.ChangedOn = (System.DateTime)row["ChangedOn"];
                //genero.ChangedBy = (System.Int32)row["ChangedBy"];
                lista.Add(genero);
            }
            return lista;
        }
    }
}
