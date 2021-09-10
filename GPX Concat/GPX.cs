using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace GPX_Concat
{
    class GPX
    {
        public string Name { get; set; }
        private readonly List<TrkPt> points;

        public GPX() { points = new List<TrkPt>(); }
        public GPX(string name, IEnumerable<TrkPt> points)
        {
            Name = name;
            this.points = new List<TrkPt>(points);
        }

        public void Append(GPX other) =>
            points.AddRange(other.points);

        private static string ns = "http://www.topografix.com/GPX/1/1";
        public static GPX ReadFile(string filename)
        {
            XNamespace ns = GPX.ns;

            var doc = XElement.Load(filename);
            var pts = from trkpt in doc.Descendants(ns + "trkpt")
                      select new TrkPt
                      {
                          Lat = double.Parse(trkpt.Attribute("lat").Value),
                          Lon = double.Parse(trkpt.Attribute("lon").Value),
                          Ele = trkpt.Element(ns + "ele") != null
                              ? (double?) double.Parse(trkpt.Element(ns + "ele").Value)
                              : null,
                          Time = trkpt.Element(ns + "time") != null
                               ? (DateTime?) DateTime.Parse(trkpt.Element(ns + "time").Value)
                               : null
                      };
            var name = doc.Element(ns + "trk").Element(ns + "name").Value;
            return new GPX(name, pts);
        }

        public void WriteFile(string filename)
        {
            using (XmlWriter gpx = XmlWriter.Create(filename))
            {
                gpx.WriteStartDocument(false);
                
                // GPX root stuff
                gpx.WriteStartElement("gpx", ns);
                gpx.WriteAttributeString("creator", "GPX Merger");
                gpx.WriteAttributeString("version", "1.1");
                gpx.WriteAttributeString(
                    "xsi",
                    "schemaLocation",
                    "http://www.w3.org/2001/XMLSchema-instance",
                    "http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd"
                );

                gpx.WriteStartElement("trk", ns);

                // Track name
                gpx.WriteStartElement("name", ns);
                gpx.WriteString(Name);
                gpx.WriteEndElement();

                // Track
                gpx.WriteStartElement("trkseg", ns);
                foreach (var trkpt in points)
                {
                    gpx.WriteStartElement("trkpt", ns);
                    gpx.WriteAttributeString("lat", trkpt.Lat.ToString());
                    gpx.WriteAttributeString("lon", trkpt.Lon.ToString());
                    if (trkpt.Ele != null)
                    {
                        gpx.WriteStartElement("ele", ns);
                        gpx.WriteString(trkpt.Ele.ToString());
                        gpx.WriteEndElement();
                    }
                    if (trkpt.Time != null)
                    {
                        gpx.WriteStartElement("time", ns);
                        gpx.WriteString(trkpt.Time.ToString());
                        gpx.WriteEndElement();
                    }
                    gpx.WriteEndElement();
                }
                gpx.WriteEndDocument();
            }
        }
    }
}
