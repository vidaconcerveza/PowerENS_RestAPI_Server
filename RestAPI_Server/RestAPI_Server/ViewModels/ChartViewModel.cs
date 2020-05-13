using RestAPI_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Server.ViewModels
{
    public class ChartViewModel
    {
        public Chart Chart { get; set; }
        public IEnumerable<Chart> Charts { get; set; }
    }
}
