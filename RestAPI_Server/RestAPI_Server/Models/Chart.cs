using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Server.Models
{
    public class Chart
    {
        public long Id { get; set; }
        public string LogTime { get; set; }
        public string AlarmMessage { get; set; }

        public double Val01 { get; set; }
        public double Val02 { get; set; }
        public double Val03 { get; set; }
        public double Val04 { get; set; }
        public double Val05 { get; set; }
        public double Val06 { get; set; }
        public double Val07 { get; set; }
        public double Val08 { get; set; }
        public double Val09 { get; set; }
        public double Val10 { get; set; }

    }
}
