using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Services
{
    public interface IDataStore<T>
    {
        bool AddItem(T item);
        bool UpdateItem(T item);
        bool DeleteItem(string id);
        T GetItem(string id); 
        List<T> ReturnList();

    }
}
