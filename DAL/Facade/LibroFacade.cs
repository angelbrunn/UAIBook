using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Facade
{
    public class LibroFacade
    {
        public List<BIZ.Libro> SeleccionarLibrosTodos()
        {
            List<BIZ.Libro> lista = new List<BIZ.Libro>();
            BIZ.Libro libro;
            //Crear una  lista Vacia
            //Crear un protoriopo Genero Vacio
            //var dt = DAL.TDG.LibroGateway.SelectAll();

            var dt = DAL.GTW.LibroGateway.SelectAll();
            foreach (DataRow row in dt.Rows)
            {
                libro = new BIZ.Libro();
                libro.Id = (System.Int32)row["Id"];
                libro.ISBN = (System.String)row["ISBN"];
                libro.Titulo = (System.String)row["Titulo"];
                libro.GeneroId = (System.Int32)row["GeneroId"];
                libro.AutorId = (System.Int32)row["AutorId"];
                libro.EditorialId = (System.Int32)row["EditorialId"];
                lista.Add(libro);
            }
            return lista;
        }

        public BIZ.Libro ObtenerUnLibro(Int32 id)
        {
            BIZ.Libro libro;
            var dt = DAL.GTW.LibroGateway.SelectOne(id);
            libro = new BIZ.Libro();
            libro.Id = (System.Int32)dt.Rows[0]["Id"];
            libro.ISBN = (System.String)dt.Rows[1]["ISBN"];
            libro.Titulo = (System.String)dt.Rows[2]["Titulo"];
            libro.GeneroId = (System.Int32)dt.Rows[3]["GeneroId"];
            libro.AutorId = (System.Int32)dt.Rows[4]["AutorId"];
            libro.EditorialId = (System.Int32)dt.Rows[5]["EditorialId"];
            return libro;
        }

        public void CrearLibro(BIZ.Libro libro)
        {
            DAL.GTW.LibroGateway.Insert(libro.Titulo);
        }

        public void ActualizarLibro(BIZ.Libro libro)
        {
            DAL.GTW.LibroGateway.Update(libro.Id, libro.Titulo);
        }
    }
}
