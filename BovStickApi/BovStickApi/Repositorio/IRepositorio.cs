using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BovStickApi.Repositorio
{
    interface IRepositorio<T>
    {
        void Insert(T item);
        void Delete(T item);
        T GetT(int id);
        T Update(T item);
        IEnumerable<T> GetItem(string query);
    }
}
