# GPX Combiner

A single dialog box. There are two tabs available:

1. Concatenate GPX to append the track of an existing gpx file to another
2. Generate veloviewer tile corners as waypoints that can be added to a gps

Concatenating tracks will only copy the track itself. Garmin extensions, waypoints, routes, and anything that's not trk, trkseg, and trkpt is ignored.  
Do be aware of device limitations when generating large areas of tile corners. The number of waypoints increases really quite quickly.
