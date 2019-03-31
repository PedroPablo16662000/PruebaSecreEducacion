using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using WebApiRest.Models;

namespace WebApiRest.Controllers
{
    public class TipoIdentificacionController : ApiController
    {
        ContactosEntities contactosDB = new ContactosEntities();
        // GET: TipoIdentificacion/GetTipoIdentificacion
        public IEnumerable<TiposIdentificacion> GetAllTiposIdentificacion()
        {
            return contactosDB.TiposIdentificacion;
        }
    }
}
