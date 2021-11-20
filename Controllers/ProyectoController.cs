using DesingYourParadise.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.IO;


namespace DesingYourParadise.Controllers
{
    public class ProyectoController : Controller
    {

        string baseUrl = "https://localhost:44366/";



        [HttpGet]
        public ActionResult Create(String identificacion)
        {
            ViewBag.cedulaObtenida = identificacion;//Se manda la identificación a la vista, con eso podremos filtrar por cliente
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> Create(Proyecto proyecto, IList<IFormFile> Foto)
        {

            Boolean resultadoProyecto = false;
            if(proyecto != null)
            {
                resultadoProyecto = true;
                ViewBag.MuestraTabla = resultadoProyecto;
            }


            
            if (Foto != null)
            {
                foreach (var item in Foto)
                {
                    if (item.Length > 0)
                    {
                        using(var stream = new MemoryStream())
                        {
                            await item.CopyToAsync(stream);
                            var fileBytes = stream.ToArray();
                            //proyecto.Foto = Convert.ToBase64String(fileBytes); 
                            proyecto.Foto = stream.ToArray();
                        }
                    }
                }
            }


            proyecto.Costo = calcularCosto(proyecto.Dormitorios, proyecto.Bathrooms, proyecto.HalfBathrooms, proyecto.Terraza, proyecto.Piso, proyecto.Mueble, proyecto.PilasAbierta, proyecto.Metros);

            proyecto.Costo_Dolar = proyecto.Costo / 626;

            


            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.PostAsJsonAsync("api/Proyecto", proyecto);
                Res.EnsureSuccessStatusCode();

                return RedirectToAction("Index", new { identificacion = proyecto.IdCliente });
            }
        }


        
        public async Task<IActionResult> Index(string identificacion)
        {
            List<Proyecto> lista_Proyectos = new List<Proyecto>();
            Boolean resultadoProyecto = false;
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Proyecto/" + identificacion);
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    lista_Proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(EmpResponse);
                    resultadoProyecto = true;
                    
                }
                ViewBag.MuestraTabla = resultadoProyecto;

                return View(lista_Proyectos);
            }
        }


        public async Task<IActionResult> Details(int Id_Proyecto)
        {

            Proyecto proyecto_detalle = null;
            using (var cliente = new HttpClient())
            {
                Boolean hayFoto = false;
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Proyecto/detalle/" + Id_Proyecto);
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    proyecto_detalle = JsonConvert.DeserializeObject<Proyecto>(EmpResponse);
                    if (proyecto_detalle.Foto is not null)
                    {
                        hayFoto = true;
                        //ViewBag.imagenEncontrada = hayFoto;
                        byte[] pic = proyecto_detalle.Foto;
                        ViewBag.picture = pic;
                        
                    }
                }
                ViewBag.project = proyecto_detalle;
                ViewBag.imagenEncontrada = hayFoto;
                return View(proyecto_detalle);
            }
        }





        [HttpGet]
        public async Task<ActionResult> Edit(String Id_Proyecto)
        {
            
            using (var cliente = new HttpClient())
            {
                Proyecto proyectoModificado = new Proyecto();
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Proyecto/detalle/" + Id_Proyecto);
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    proyectoModificado = JsonConvert.DeserializeObject<Proyecto>(EmpResponse);
                    
                }

                return View(proyectoModificado);
            }

        }

        



        public async Task<ActionResult> Edit(Proyecto proyecto, IList<IFormFile> Foto)
        {
            proyecto.Costo = calcularCosto(proyecto.Dormitorios, proyecto.Bathrooms, proyecto.HalfBathrooms, proyecto.Terraza, proyecto.Piso, proyecto.Mueble, proyecto.PilasAbierta, proyecto.Metros);
            proyecto.Costo_Dolar = proyecto.Costo / 626;


            if (Foto != null)
            {
                foreach (var item in Foto)
                {
                    if (item.Length > 0)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await item.CopyToAsync(stream);
                            var fileBytes = stream.ToArray();
                            proyecto.Foto = stream.ToArray();
                        }
                    }
                }
            }

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.PutAsJsonAsync("api/Proyecto", proyecto);

                Res.EnsureSuccessStatusCode();

                return RedirectToAction("Index", new { identificacion = proyecto.IdCliente });
            }
        }



        private double calcularCosto(CantidadDormitorios cantDormit, Bathrooms cantiBanosComp, HalfBathrooms CantMediBanos, TerrazaSize terTam, TipoPiso tipo_piso, MuebleCocina mueble_Cocina, Boolean pilas, Metros totalMetros)
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
            switch (cantDormit)
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


            switch (cantiBanosComp)
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


            switch (CantMediBanos)
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

            switch (terTam)
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

            switch (tipo_piso)
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

            switch (mueble_Cocina)
            {
                case MuebleCocina.Granito:
                    resultadoMueble = 0;
                    break;
                case MuebleCocina.Cuarzo:
                    resultadoMueble = 1;
                    break;
            }

            switch (totalMetros)
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


            if (pilas == true)
            {
                areaPilas = 2;
            }

            if (pilas == false)
            {
                areaPilas = 3;
            }

            double costo = ((cantDormitorios + cantBathrooms + cantHalfBathrooms + resultadoTerraza + resultadoPiso + resultadoMueble) + (areaPilas * resultadoMetros)) * 20000;



            
            return costo;
        }



    }//Fin de la clase
}
