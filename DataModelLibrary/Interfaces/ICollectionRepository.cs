using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelLibrary.Interfaces
{
    public interface ICollectionRepository<T> where T : class // indicates that T must be a reference type (class, interface, delegate or array)
    {
        IEnumerable<T> GetAll();
        void Add(T collectible);
        void Delete(int id);
    }
}
