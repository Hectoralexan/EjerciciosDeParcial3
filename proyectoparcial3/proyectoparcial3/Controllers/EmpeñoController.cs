using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace proyectoparcial3.Controllers
{
    public class EmpeñoController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add()
        {
            using (Models.CasaDeEmmpeñoEntities db = new Models.CasaDeEmmpeñoEntities())
            {
                var oempeño = new Models.Empeño();
                oempeño.id = 12;
                oempeño.Nombre = "consoladeVideojuegos";
                oempeño.Estado = "8";
                oempeño.credito = 300;
                db.SaveChanges();
                db.Dispose();
           
                return Ok("credito hecho con exito!!");

            }
        }
        
        
    }
}