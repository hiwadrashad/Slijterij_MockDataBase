using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Models
{
    public class ModelClient
    {
        public string id { get; set; }

        public string Name { get; set; }

        public Dictionary<ModelWhiskey, int> ReservedWhiskeys { get; set; }
    }
}
