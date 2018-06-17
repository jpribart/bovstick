using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BovStickApi.Controllers
{
    public class BovinoController : ApiController
    {
        // GET: api/Bovino
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bovino/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bovino
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bovino/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bovino/5
        public void Delete(int id)
        {
        }
    }
}
