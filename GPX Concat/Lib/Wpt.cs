using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPX_Concat
{
    class Wpt
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double? Ele { get; set; }
        public DateTime? Time { get; set; }
        public string Name { get; set; }
        public string Sym { get; set; }
    }
}
