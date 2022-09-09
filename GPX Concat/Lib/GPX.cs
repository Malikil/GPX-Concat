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
        private readonly HashSet<Wpt> waypoints;

        public GPX() : this(null, new TrkPt[] { }) { }
        public GPX(string name, IEnumerable<TrkPt> points) : this(name, points, new Wpt[] { }) { }
        public GPX(string name, IEnumerable<TrkPt> points, IEnumerable<Wpt> waypoints)
        {
            Name = name;
            this.points = new List<TrkPt>(points);
            this.waypoints = new HashSet<Wpt>(waypoints);
        }

        public void Append(GPX other) =>
            points.AddRange(other.points);

        public void AddWaypoint(Wpt waypoint) =>
            waypoints.Add(waypoint);

        private static readonly string ns = "http://www.topografix.com/GPX/1/1";
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
            var wpts = from wpt in doc.Descendants(ns + "wpt")
                       select new Wpt
                       {
                           Lat = double.Parse(wpt.Attribute("lat").Value),
                           Lon = double.Parse(wpt.Attribute("lon").Value),
                           Name = wpt.Element(ns + "name").Value,
                           Ele = wpt.Element(ns + "ele") != null
                               ? (double?) double.Parse(wpt.Element(ns + "ele").Value)
                               : null,
                           Time = wpt.Element(ns + "time") != null
                                ? (DateTime?) DateTime.Parse(wpt.Element(ns + "time").Value)
                                : null,
                           Sym = wpt.Element(ns + "sym").Value
                       };
            var name = doc.Element(ns + "trk")?.Element(ns + "name")?.Value;
            return new GPX(name, pts, wpts);
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

                // Waypoints
                foreach (var wpt in waypoints)
                {
                    gpx.WriteStartElement("wpt", ns);
                    gpx.WriteAttributeString("lat", wpt.Lat.ToString());
                    gpx.WriteAttributeString("lon", wpt.Lon.ToString());

                    gpx.WriteStartElement("name", ns);
                    gpx.WriteString(wpt.Name);
                    gpx.WriteEndElement();

                    if (wpt.Sym != null)
                    {
                        gpx.WriteStartElement("sym", ns);
                        gpx.WriteString(wpt.Sym);
                        gpx.WriteEndElement();
                    }
                    if (wpt.Ele != null)
                    {
                        gpx.WriteStartElement("ele", ns);
                        gpx.WriteString(wpt.Ele.ToString());
                        gpx.WriteEndElement();
                    }
                    if (wpt.Time != null)
                    {
                        gpx.WriteStartElement("time", ns);
                        gpx.WriteString(wpt.Time.ToString());
                        gpx.WriteEndElement();
                    }
                    gpx.WriteEndElement();
                }

                if (points.Count > 0)
                {
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
                }
                gpx.WriteEndDocument();
            }
        }
    }
}
