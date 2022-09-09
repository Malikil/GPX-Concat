using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPX_Concat
{
    class TrkPt
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double? Ele { get; set; }
        public DateTime? Time { get; set; }

        public double Distance(TrkPt other)
        {
            // This is wrong
            var a = Lat - other.Lat;
            var b = Lon - other.Lon;
            return Math.Sqrt(a * a + b * b);
        }
    }
}
