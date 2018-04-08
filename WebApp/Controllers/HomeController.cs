using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(string data)
        {
            return View();
        }
        // GET: /Home/
        public ActionResult Details()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Details(string data)
        {
            return View();
        }
        // GET: /Home/
        public ActionResult About()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult About(string data)
        {
            return View();
        }
        // GET: /Home/
        public ActionResult Contact()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Contact(string data)
        {
            return View();
        }
        // GET: /Home/
        public ActionResult Admin()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Admin(string data)
        {
            return View();
        }
	}
}