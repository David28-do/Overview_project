using Newtonsoft.Json;
using Overview_project.Models.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Overview_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult detalles()
        {

            return View();
        }

        public ActionResult Index(string departamento)

        {
            Contacto objContac = new Contacto();
            HttpClient Cliente3 = new HttpClient();//clase para llamar las api rest
            Cliente3.BaseAddress = new Uri("https://sigma-studios.s3-us-west-2.amazonaws.com/");
            var request = Cliente3.GetAsync("test/colombia.json").Result;//cuando invoque este metodono se va qudar esperando, va seguir con laa ejecucion


            if (request.IsSuccessStatusCode)
            {
                var result = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<departamento>(result);





            }
            return View();
        }
    }
}

    
