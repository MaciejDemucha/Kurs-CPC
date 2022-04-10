using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejDemuchaLab4.Models
{
    public class SearchByPriceViewModel
    {
        public SearchByPriceViewModel(string min, string max)
        {
            this.Min = min;
            this.Max = max;
        }
        public string Min { get; set; }
        public string Max { get; set; }
    }
}
