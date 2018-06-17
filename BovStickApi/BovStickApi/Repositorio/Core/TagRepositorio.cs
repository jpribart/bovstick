using BovStickApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BovStickApi.Repositorio.Core
{
    public class TagRepositorio : IRepositorio<Tag>
    {
        static List<Tag> _Tag = new List<Tag>();
        public void Delete(Tag item)
        {
            _Tag.Remove(item);
        }

        public IEnumerable<Tag> GetItem(string query)
        {
            return _Tag.AsEnumerable();
        }

        public Tag GetT(int id)
        {
            return _Tag.First(x => x.Id == id);
        }

        public void Insert(Tag item)
        {
            _Tag.Add(item);
        }

        public Tag Update(Tag item)
        {
            var tag = _Tag.First(x => x.Id == item.Id);
            _Tag.Remove(tag);
            _Tag.Add(item);
            return item;
        }
    }
}