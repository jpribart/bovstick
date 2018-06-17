using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BovStickApi.Controllers
{
    public class PiqueteController : ApiController
    {
        // GET: api/Piquete
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Piquete/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Piquete
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Piquete/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Piquete/5
        public void Delete(int id)
        {
        }
    }
}
