using BovStickApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BovStickApi.Repositorio.Core
{
    public class GestacaoRepositorio : IRepositorio<Gestacao>
    {
        static List<Gestacao> _Gest = new List<Gestacao>();
        public void Delete(Gestacao item)
        {
            _Gest.Remove(item);
        }

        public IEnumerable<Gestacao> GetItem(string query)
        {
           return _Gest.AsEnumerable();
        }

        public Gestacao GetT(int id)
        {
            return _Gest.First(x => x.ID == id);
        }

        public void Insert(Gestacao item)
        {
            _Gest.Add(item);
        }

        public Gestacao Update(Gestacao item)
        {
            var Gest = _Gest.First(x => x.ID == item.ID);
            _Gest.Remove(Gest);
            _Gest.Add(item);
            return item;
        }
    }
}