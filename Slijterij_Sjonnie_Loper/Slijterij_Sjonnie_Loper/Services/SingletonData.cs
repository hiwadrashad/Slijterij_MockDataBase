using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Services
{
    public static class SingletonData
    {
        public static MockDataStoreClient StoreDataClient { get; set; }

        public static MockDataStoreCollaborator StoreDataCollaborator { get; set; }

        public static MockDataStoreWhiskey StoreDataWhiskey { get; set; }

        public static bool initialized = false;
    }
}
