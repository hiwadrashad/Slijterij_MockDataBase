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

        public List<string> Whiskeys { get; set; }

        public List<int> Amount { get; set; }
    }
}
