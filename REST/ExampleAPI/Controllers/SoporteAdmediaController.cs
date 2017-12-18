using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace ExampleAPI.Controllers
{
    public class SoporteAdmediaController : ApiController
    {
        // GET: api/Product/5
        public IHttpActionResult Get()
        {
            try
            {
                var sop = Enumerable.Range(1, 22).Select(x => new SoporteAdmedia()
                {
                    CodigoVehiculo = x.ToString(),
                    DescripcionAdmedia = x.ToString(),
                    IdMedio = x,
                    IdSoporte = x.ToString(),
                    IdTipoSoporte = x.ToString()
                });

                return Ok(sop);
            }
            catch (Exception Exception)
            {
                return new BadRequestErrorMessageResult(Exception.Message, this);
            }
        }

        public HttpResponseMessage Post(SoporteAdmedia soporteAdmedia)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage Put(SoporteAdmedia soporteAdmedia, int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete(string id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
