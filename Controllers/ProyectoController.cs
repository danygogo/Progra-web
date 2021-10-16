﻿using DesingYourParadise.Models;
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
        public ActionResult Index(String identificacion)
        {
            List<Models.Proyecto> listaProyecto;
            List<Models.Proyecto> listaFiltrada;
            listaProyecto = ObtenerProyecto();

            Boolean resultadoProyecto = false;

            listaFiltrada = listaProyecto.Where(proj => (proj.IdCliente.Equals(identificacion))).ToList();

            if (listaFiltrada.Count() == 0)
            {
                ViewBag.MuestraTabla = resultadoProyecto;
                return View();
            }
            else
            {
                resultadoProyecto = true;
                ViewBag.MuestraTabla = resultadoProyecto;
                return View(listaFiltrada);
            }  
        }


     

        // GET: ProyectoController/Create
        [HttpGet]
        public ActionResult Create(String identificacion)
        {
            List<Models.Proyecto> listaProyecto;
            listaProyecto = ObtenerProyecto();

            Models.Proyecto proyecto = new Models.Proyecto();

            //Este consecutivo se necesita para que los códigos de proyecto se creen automáticamente
            int consecutivo = 0;

            if (listaProyecto.Count() == 0)
            {
                consecutivo = listaProyecto.Count + 1;
            }
            else
            {
                consecutivo = listaProyecto.Count + 1;
            }

            ViewBag.resultadoConsecutivo = consecutivo;//Se manda el consecutivo a la vista
            ViewBag.cedulaObtenida = identificacion;//Se manda la identificación a la vista, con eso podremos filtrar por cliente

            return View();
        }



        // POST: ProyectoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Proyecto proyecto)
        {
            //Variables para el cálculo
            int cantDormitorios = 0;
            int cantBathrooms = 0;
            int cantHalfBathrooms = 0;
            int resultadoTerraza = 0;
            int resultadoPiso = 0;
            int resultadoMueble = 0;
            int areaPilas = 0;
            int resultadoMetros = 0;

            
            //Se realizan estos switch para poder obtener la información que viene de
            //los select y poder hacer el cálculo
            switch (proyecto.dormitorios)
            {
                case CantidadDormitorios.Uno:
                    cantDormitorios = 1;
                    break;
                case CantidadDormitorios.Dos:
                    cantDormitorios = 2;
                    break;
                case CantidadDormitorios.Tres:
                    cantDormitorios = 3;
                    break;
                case CantidadDormitorios.Cuatro:
                    cantDormitorios = 4;
                    break;
                case CantidadDormitorios.Cinco:
                    cantDormitorios = 5;
                    break;
                case CantidadDormitorios.Seis:
                    cantDormitorios = 6;
                    break;
            }


            switch (proyecto.bathrooms)
            {
                case Bathrooms.Uno:
                    cantBathrooms = 1;
                    break;
                case Bathrooms.Dos:
                    cantBathrooms = 2;
                    break;
                case Bathrooms.Tres:
                    cantBathrooms = 3;
                    break;
                case Bathrooms.Cuatro:
                    cantBathrooms = 4;
                    break;
                case Bathrooms.Cinco:
                    cantBathrooms = 5;
                    break;
            }


            switch (proyecto.halfBathrooms)
            {
                case HalfBathrooms.Uno:
                    cantHalfBathrooms = 1;
                    break;
                case HalfBathrooms.Dos:
                    cantHalfBathrooms = 2;
                    break;
                case HalfBathrooms.Tres:
                    cantHalfBathrooms = 3;
                    break;
            }

            switch (proyecto.terraza)
            {
                case TerrazaSize.Reducida:
                    resultadoTerraza = 0;
                    break;
                case TerrazaSize.Mediana:
                    resultadoTerraza = 1;
                    break;
                case TerrazaSize.Grande:
                    resultadoTerraza = 2;
                    break;
            }

            switch (proyecto.piso)
            {
                case TipoPiso.Concreto:
                    resultadoPiso = 0;
                    break;
                case TipoPiso.Porcelanato:
                    resultadoPiso = 1;
                    break;
                case TipoPiso.Ceramica:
                    resultadoPiso = 2;
                    break;
            }

            switch (proyecto.mueble)
            {
                case MuebleCocina.Granito:
                    resultadoMueble = 0;
                    break;
                case MuebleCocina.Cuarzo:
                    resultadoMueble = 1;
                    break;
            }

            switch (proyecto.metros)
            {
                case Metros.cincuenta:
                    resultadoMetros = 0;
                    break;
                case Metros.ochenta:
                    resultadoMetros = 1;
                    break;
                case Metros.cien:
                    resultadoMetros = 2;
                    break;
                case Metros.cientocincuenta:
                    resultadoMetros = 3;
                    break;
                case Metros.doscientos:
                    resultadoMetros = 4;
                    break;
            }


            if(proyecto.PilasAbierta == true)
            {
                areaPilas = 2;
            }
            
            if(proyecto.PilasAbierta == false)
            {
                areaPilas = 3;
            }

            proyecto.costo = ((cantDormitorios + cantBathrooms + cantHalfBathrooms + resultadoTerraza + resultadoPiso + resultadoMueble) + (areaPilas * resultadoMetros)) * 20000;



            try
            {
                List<Models.Proyecto> listaProyecto;

                listaProyecto = ObtenerProyecto();

                listaProyecto.Add(proyecto);
                return RedirectToAction("Index", new { identificacion = proyecto.IdCliente });
                //Se agrega la identificacion del cliente para que muestre los proyectos de ese cliente y el costo
              
            }
            catch
            {
                return View();
            }
        }


        //Metodo para obtener los proyectos que de cache
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
