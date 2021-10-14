using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DesingYourParadise.Controllers
{
    public class ProyectoController : Controller
    {
        private IMemoryCache _cacheProyecto;

        public ProyectoController(IMemoryCache memoryCacheProyecto)
        {
            _cacheProyecto = memoryCacheProyecto;
        }
        // GET: ProyectoController
        public ActionResult Index()
        {
            List<Models.Proyecto> listaProyecto;
            listaProyecto = ObtenerProyecto();
            return View(listaProyecto);
        }



        // GET: ProyectoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: ProyectoController/Create
        public ActionResult Create()
        {
            List<Models.Proyecto> listaProyecto;
            listaProyecto = ObtenerProyecto();
            Models.Proyecto proyecto = new Models.Proyecto();
            int consecutivo = 0;
            if (listaProyecto.Count() == 0)
            {
                consecutivo = listaProyecto.Count + 1;
            }
            else
            {
                consecutivo = listaProyecto.Count + 1;
            }

            ViewBag.resultadoConsecutivo = consecutivo;

            return View();
        }



        // POST: ProyectoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Proyecto proyecto)
        {
            try
            {
                List<Models.Proyecto> listaProyecto;

                listaProyecto = ObtenerProyecto();

                listaProyecto.Add(proyecto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        private List<Models.Proyecto> ObtenerProyecto()
        {
            List<Models.Proyecto> listaProyectos;

            if (_cacheProyecto.Get("ListaProyectos") is null)
            {
                listaProyectos = new List<Models.Proyecto>();
                _cacheProyecto.Set("ListaProyectos", listaProyectos);
            }
            else
            {
                listaProyectos = (List<Models.Proyecto>)_cacheProyecto.Get("ListaProyectos");

            }

            return listaProyectos;
        }




    }
}
