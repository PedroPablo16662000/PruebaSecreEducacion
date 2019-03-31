using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Mvc;
using WebApiRest.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApiRest.Controllers
{
    public class ContactosController : ApiController
    {
        ContactosEntities contactosDB = new ContactosEntities();
        public IEnumerable<Contactos> GetAllContactos()
        {
            return contactosDB.Contactos;
        }

        [HttpPost]
        [Route("api/Contactos/Post")]
        public HttpResponseMessage Post(FormDataCollection collection)
        {          
            Contactos contacto = new Contactos();
            contacto.nombresContacto = collection["nombresContacto"].ToString();
            contacto.apellidosContacto = collection["apellidosContacto"].ToString();
            contacto.idTipoIdentificacion = int.Parse(collection["idTipoIdentificacion"].ToString());
            contacto.numeroIdentificacionContacto = Int64.Parse(collection["numeroIdentificacionContacto"].ToString());
            contacto.telefonosContacto = collection["telefonosContacto"].ToString();
            contacto.correoContacto = collection["correoContacto"].ToString();
            contactosDB.Contactos.Add(contacto);
            int guarda = contactosDB.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
