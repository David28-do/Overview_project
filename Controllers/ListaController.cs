using Newtonsoft.Json;
using Overview_project.Models;
using Overview_project.Models.viewmodel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Overview_project.Helper;

namespace Overview_project.Controllers
{
    public class ListaController : Controller
    {
        // GET: Lista
        public ActionResult Index()

        {
            HttpClient Cliente = new HttpClient();//clase para llamar las api rest
            Cliente.BaseAddress = new Uri("https://sigma-studios.s3-us-west-2.amazonaws.com/");
            var request = Cliente.GetAsync("test/colombia.json").Result;

            if (request.IsSuccessStatusCode)
            {
                var result = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<departamento>(result);
                return View();
            }
            
            return View(new List<departamento>());
        }
        public ActionResult Nuevo()
        {
            DepartamentoHelper listaDepartamento = new DepartamentoHelper();
            ViewBag.MiListado = listaDepartamento.obtenerListado();
            return View();

        }
        [HttpPost]
        public ActionResult Nuevo(Contacto contactoModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (admin_sigmatestEntities db = new admin_sigmatestEntities())
                    {
                        contact objContacto = new contact();
                        objContacto.id = contactoModel.id_entity;
                        objContacto.name = contactoModel.name_entity;
                        objContacto.email = contactoModel.email_entity;
                        objContacto.city = contactoModel.city_entity;
                        objContacto.state = contactoModel.state_entity;
                        db.contacts.Add(objContacto);
                        db.SaveChanges();
                    }
                    return Redirect("~/Lista");
                }
                return View(contactoModel);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
