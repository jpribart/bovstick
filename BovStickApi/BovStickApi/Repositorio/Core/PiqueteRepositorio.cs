using BovStickApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BovStickApi.Repositorio.Core
{
    public class PiqueteRepositorio : IRepositorio<Piquete>
    {
        static List<Piquete> _Piq = new List<Piquete>();
        public void Delete(Piquete item)
        {
            _Piq.Remove(item);
        }

        public IEnumerable<Piquete> GetItem(string query)
        {
            return _Piq.AsEnumerable();
        }

        public Piquete GetT(int id)
        {
            return _Piq.First(x => x.Id == id);
        }

        public void Insert(Piquete item)
        {
            _Piq.Add(item);
        }

        public Piquete Update(Piquete item)
        {
           var piq= _Piq.First(x => x.Id == item.Id);
            _Piq.Remove(piq);
            _Piq.Add(item);
            return item;
        }
    }
}