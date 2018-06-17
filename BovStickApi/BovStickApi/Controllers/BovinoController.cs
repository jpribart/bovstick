using BovStickApi.Models;
using BovStickApi.Repositorio.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BovStickApi.Controllers
{
    public class BovinoController : ApiController
    {
        BovinoRepositorio rep = new BovinoRepositorio();
        
        // GET: api/Bovino
        public IEnumerable<Bovino> Get()
        {

            rep.Insert(new Bovino() { Id = 1, Descricao = "Leiteira", cor = Color.Brown, IdGestacao = 1, IdPiquete = 98, IdTag = 4 });
            return rep.GetItem(null);
        }

        // GET: api/Bovino/5
        public Bovino Get(int id)
        {
            return rep.GetT(id);
        }

        // POST: api/Bovino
        public void Post([FromBody]Bovino value)
        {
            rep.Insert(value);
        }

        // PUT: api/Bovino/5
        public void Put(int id, [FromBody]Bovino value)
        {
            rep.Update(value);
        }

        // DELETE: api/Bovino/5
        public void Delete(int id)
        {
            var rep1 = rep.GetT(id);
            rep.Delete(rep1);
        }
    }
}
