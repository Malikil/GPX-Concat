using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace GPX_Concat.Lib
{
    [DebuggerDisplay("Lat = {Lat}, Lon = {Lon}")]
    struct LatLon
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    class TileCalculator
    {
        private const double RAD2DEG = 180 / Math.PI;
        private const double PI_4 = Math.PI / 4;
        private static readonly double E_PI = Math.Exp(Math.PI);
        private static readonly double MAX_LAT = (2 * Math.Atan(E_PI) - Math.PI / 2) * RAD2DEG;

        private static double Y2Lat(double y) => (Math.Atan(Math.Exp(y / RAD2DEG)) / PI_4 - 1) * 90;
        private static double Lat2Y(double lat) => Math.Log(Math.Tan((lat / 90 + 1) * PI_4)) * RAD2DEG;

        public static Point Tile(double lat, double lon) => Tile(lat, lon, 14);
        public static Point Tile(double lat, double lon, int zoom)
        {
            double INC_X = 360 / Math.Pow(2, zoom);
            double INC_Y = (Lat2Y(MAX_LAT) * 2) / Math.Pow(2, zoom);
            int zeroTile = (int)Math.Pow(2, zoom - 1);

            int tileX = (int)(lon / INC_X);
            int tileY = (int)(Lat2Y(lat) / INC_Y);

            int nMod = lat > 0 ? 1 : 0;
            int wMod = lon < 0 ? 1 : 0;

            return new Point
            {
                X = tileX + zeroTile - wMod,
                Y = zeroTile - tileY - nMod
            };
        }

        public static IReadOnlyCollection<LatLon> Corners(int tileX, int tileY) => Corners(tileX, tileY, 14);
        public static IReadOnlyCollection<LatLon> Corners(int tileX, int tileY, int zoom)
        {
            double INC_X = 360 / Math.Pow(2, zoom);
            double INC_Y = (Lat2Y(MAX_LAT) * 2) / Math.Pow(2, zoom);
            int zeroTile = (int)Math.Pow(2, zoom - 1);

            tileX -= zeroTile;
            tileY = zeroTile - tileY;

            return new LatLon[]
            {
                new LatLon { Lat = Y2Lat(tileY * INC_Y), Lon = tileX * INC_X },
                new LatLon { Lat = Y2Lat((tileY - 1) * INC_Y), Lon = tileX * INC_X },
                new LatLon { Lat = Y2Lat(tileY * INC_Y), Lon = (tileX + 1) * INC_X },
                new LatLon { Lat = Y2Lat((tileY - 1) * INC_Y), Lon = (tileX + 1) * INC_X },
            };
        }
    }
}
