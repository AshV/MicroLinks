using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroLinksAPI.Controllers
{
    public class LinksController : ApiController
    {
        // GET: api/Links
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Moved);
            response.Headers.Location = new Uri("http://ashv.ml", UriKind.RelativeOrAbsolute);
            return (response);
        }

        // GET: api/Links/5
        public HttpResponseMessage Get(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Moved);
            response.Headers.Location = new Uri("http://ashv.ml", UriKind.RelativeOrAbsolute);
            return (response);
        }

        // POST: api/Links
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Links/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Links/5
        public void Delete(int id)
        {
        }
    }
}
