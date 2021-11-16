using Microsoft.AspNetCore.Http;
using DesingYourParadise.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DesingYourParadise.Controllers
{
    public class ClienteController : Controller
    {
        //Aca es donde se encuentra el API
        string baseUrl = "https://localhost:44366/";


 

        public async Task<ActionResult> Index()
        {
            List<Cliente> lista_Clientes = new List<Cliente>();
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Cliente");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    lista_Clientes = JsonConvert.DeserializeObject<List<Cliente>>(EmpResponse);
                }

                return View(lista_Clientes);
            }

        }

        
        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public async Task<ActionResult> Create(Cliente clienteNuevo)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.PostAsJsonAsync("api/Cliente", clienteNuevo);
                Res.EnsureSuccessStatusCode();

                return RedirectToAction(nameof(Index));
            }
        }


        //GET
        public async Task<ActionResult> Edit(String identificacion)
        {
            List<Cliente> lista_Clientes = new List<Cliente>();
            using (var cliente = new HttpClient())
            {
                Cliente clienteResultado = new Cliente();
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Cliente");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    
                    lista_Clientes = JsonConvert.DeserializeObject<List<Cliente>>(EmpResponse);
                    clienteResultado = lista_Clientes.Find(customer => customer.Cedula.Equals(identificacion));
                }

                return View(clienteResultado);
            }

        }



   
        public async Task<ActionResult> Editar(Cliente clienteRecibido, string id_cliente)
        {


            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.PutAsJsonAsync("api/Cliente", clienteRecibido);

                Res.EnsureSuccessStatusCode();

                return RedirectToAction(nameof(Index));
            }
        }


        public async Task<ActionResult> Filtrar(String cedula)
        {
            List<Cliente> lista_Clientes = new List<Cliente>();
            List<Cliente> clienteFiltrado;

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri(baseUrl);
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await cliente.GetAsync("api/Cliente");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    lista_Clientes = JsonConvert.DeserializeObject<List<Cliente>>(EmpResponse);
                }


                int mostrar = 1;

                if (cedula is null)
                {
                    ViewBag.condicional = mostrar;
                    return View();
                }
                else
                {
                    clienteFiltrado = lista_Clientes.Where(customer => customer.Cedula.Equals(cedula)).ToList();
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
        }


    }//Fin de la clase
}

