using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Overview_project.Helper
{
    public class DepartamentoHelper
    {
        public List<SelectListItem> obtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Amazonas",
                    Value = "Amazonas",
                },
                new SelectListItem()
                {
                    Text = "Atlantico",
                    Value = "Atlantico",
                },
                 new SelectListItem()
                {
                    Text = "Caqueta",
                    Value = "Caqueta",
                },
                new SelectListItem()
                {
                    Text = "Cesar",
                    Value = "Cesar",
                },
                 new SelectListItem()
                {
                    Text = "Choco",
                    Value = "Choco",
                },
                new SelectListItem()
                {
                    Text = "Cordoba",
                    Value = "Cordoba",
                },
                 new SelectListItem()
                {
                    Text = "Guainia",
                    Value = "Guainia",
                },
                new SelectListItem()
                {
                    Text = "Guaviare",
                    Value = "Guaviare",
                },
                 new SelectListItem()
                {
                    Text = "Huila",
                    Value = "Huila",
                },
                new SelectListItem()
                {
                    Text = "Guajira",
                    Value = "Guajira",
                },
                 new SelectListItem()
                {
                    Text = "Putumayo",
                    Value = "Putumayo",
                },
                new SelectListItem()
                {
                    Text = "Quindio",
                    Value = "Quindio",
                },
                 new SelectListItem()
                {
                    Text = "San andres",
                    Value = "San andres",
                },
                new SelectListItem()
                {
                    Text = "Sucre",
                    Value = "Sucre",
                },
                new SelectListItem()
                {
                    Text = "Tolima",
                    Value = "Tolima",
                },
                 new SelectListItem()
                {
                    Text = "Vaupes",
                    Value = "Vaupes",
                },
                new SelectListItem()
                {
                    Text = "Vichada",
                    Value = "Vichada",
                }
            };
        }
    }
}