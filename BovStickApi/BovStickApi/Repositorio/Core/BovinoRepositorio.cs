using BovStickApi.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BovStickApi.Repositorio.Core
{
    public class BovinoRepositorio : IRepositorio<Bovino>
    {
        static List<Bovino> bov = new List<Bovino>();
        public void Delete(Bovino item)
        {
            bov.Remove(item);
        }

        public IEnumerable<Bovino> GetItem(string query)
        {
            return bov.AsEnumerable();
        }

        public Bovino GetT(int id)
        {
            return bov.First(x => x.Id == id);
        }

        public void Insert(Bovino item)
        {
            bov.Add(item);
        }

        public Bovino Update(Bovino item)
        {
            var boi =bov.First(x => x.Id == item.Id);
            bov.Remove(boi);
           bov.Add(item);
            return item;
        }
      
        
    }
}