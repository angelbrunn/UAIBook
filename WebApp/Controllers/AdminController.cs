using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AdminController : Controller
    {
        /*
        // GET: /Admin/ 
        public ActionResult Admin()
        {
            return View();
        }*/
        // GET: Admin
        public ActionResult Admin()
        {
            //Creo un libro segun el modelo libro
            List<Libro> libro=  new List<Libro>();
            
            //Busco todos los libros que tengo y los muestro por pantalla  
            //var lista = new UAIBook.BLL.LibroUAIBoook().ListarTodosLosLibros();

            //Antes de probar el backend le teo un valor de prueba
            //Ini - Creo objeto libro y guardo valores
            Libro libo_01 = new Libro();
            libo_01.Id = 1;
            libo_01.ISBN = "123-000";
            libo_01.Titulo = "Libro de prueba 01";
            libo_01.GeneroId = 1;
            libo_01.AutorId = 1;
            libo_01.EditorialId = 1;
            libro.Add(libo_01);
            //Fin - Creo objeto libro y guardo valores
            //Ini - Creo objeto libro y guardo valores
            Libro libo_02 = new Libro();
            libo_02.Id = 2;
            libo_02.ISBN = "456-000";
            libo_02.Titulo = "Libro de prueba 02";
            libo_02.GeneroId = 1;
            libo_02.AutorId = 1;
            libo_02.EditorialId = 1;
            libro.Add(libo_02);
            //Fin - Creo objeto libro y guardo valores
            //Ini - Creo objeto libro y guardo valores
            Libro libo_03 = new Libro();
            libo_03.Id = 3;
            libo_03.ISBN = "678-000";
            libo_03.Titulo = "Libro de prueba 03";
            libo_03.GeneroId = 1;
            libo_03.AutorId = 1;
            libo_03.EditorialId = 1;
            libro.Add(libo_03);
            //Fin - Creo objeto libro y guardo valores
            return View(libro); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            BIZ.Libro libro = new BIZ.Libro();
            libro.Titulo = form["Titulo"];
            //Agregar todos los datos necesarios para crear un libro
            new BLL.LibroUAIBoook().CrearLibro(libro);
            return RedirectToAction("Admin");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit(Int32 id)
        {
            var libro = new BLL.LibroUAIBoook().ObtenerLibro(id);
            return View(libro);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(FormCollection form, Int32 id)
        {
           BIZ.Libro libro = new BIZ.Libro();
            libro.Id = id;
            libro.Titulo = form["Titulo"];
            //Agregar todos los datos necesarios para editar un libro
            new BLL.LibroUAIBoook().ActualizarLibro(libro);
            return RedirectToAction("Admin");
        } 
    }
}