using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Models
{
    public class ModelWhiskey
    {

        public string Id { get; set; }
        public string Name { get; set; }

        public string Age { get; set; }

        public string ProductionSite { get; set; }

        public string AlcoholPercentage { get; set; }

        public string TypeWhiskey { get; set; }

        public IFormFile Label { get; set; }

        public string Price { get; set; }

        public int AmountOfBottles { get; set; }
    }
}
