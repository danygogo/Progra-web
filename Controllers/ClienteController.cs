using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingYourParadise.Controllers
{
    public class ClienteController : Controller
    {
        private IMemoryCache _cache;
        
        public ClienteController (IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }
        
        // GET: ClienteController
        public ActionResult Index()
        {
            List<Models.Cliente> listaCliente;

            listaCliente = ObtenerCliente();
            return View(listaCliente);
            
        }


        public ActionResult Filtrar(long cedula)
        {
            List<Models.Cliente> listaCliente;
            List<Models.Cliente> clienteFiltrado;

            listaCliente = ObtenerCliente();

            int mostrar = 1;

            if (cedula == 0)
            {
                ViewBag.condicional = mostrar;
                return View();
            }
            else
            {
                clienteFiltrado = listaCliente.Where(customer => customer.Cedula == cedula).ToList();
                if (clienteFiltrado.Count() == 0)
                {
                    mostrar = 2;
                    ViewBag.condicional = mostrar;
                    return View();
                }
                else
                {
                    mostrar = 3;
                    ViewBag.condicional = mostrar;
                    return View(clienteFiltrado);
                }
            }
        }




        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Cliente cliente) 
        {
            try
            {
                List<Models.Cliente> listaCliente;

                listaCliente = ObtenerCliente();

                listaCliente.Add(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: ClienteController/Edit/5
        public ActionResult Edit(long identificacion)
        {

            List<Models.Cliente> listaCliente;
            Models.Cliente cliente;

            listaCliente = ObtenerCliente();

            cliente = listaCliente.Find(customer => customer.Cedula == identificacion);

            return View(cliente);

        }



        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Cliente cliente)
        {

            try
            {
                List<Models.Cliente> listaCliente;
                Models.Cliente clienteModificado;

                listaCliente = ObtenerCliente();

                clienteModificado = listaCliente.Find(customer => customer.Cedula == cliente.Cedula);

             
                clienteModificado.Nombre = cliente.Nombre;
                clienteModificado.Telefono = cliente.Telefono;


                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

 

    



        //Metodo para obtener datos de cache
        private List<Models.Cliente> ObtenerCliente()
        {
            List<Models.Cliente> listaClientes;

            if (_cache.Get("ListaClientes") is null)
            {
                listaClientes = new List<Models.Cliente>();
                _cache.Set("ListaClientes", listaClientes);
            }
            else
            {
                listaClientes = (List<Models.Cliente>)_cache.Get("ListaClientes");

            }

            return listaClientes;
        }



    }//Fin de la clase
}
