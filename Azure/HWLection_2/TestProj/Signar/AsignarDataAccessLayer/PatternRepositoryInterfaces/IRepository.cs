using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignarDataAccessLayer.PatternRepositoryInterfaces
{
    interface IRepository<T> : IDisposable where T: class
    {

        IEnumerable<T> GetItemsList();

        T GetItem(int itemID);

        void Create(T item);

        void Update(T item);

        void Delete(int itemID);

        void Save();

    }
}
