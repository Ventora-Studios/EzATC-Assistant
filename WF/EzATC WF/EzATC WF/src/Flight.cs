using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzATC_WF.src
{
    class Flight
    {
        private String callsign, departure, destination, route, sqw, actype;
        private FlightType ft;

        public Flight(string callsign, string departure, string destination, string route, string sqw, string actype, FlightType ft)
        {
            this.callsign = callsign;
            this.departure = departure;
            this.destination = destination;
            this.route = route;
            this.sqw = sqw;
            this.actype = actype;
            this.ft = ft;
        }

        public string Callsign { get => callsign; set => callsign = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Route { get => route; set => route = value; }
        public string Sqw { get => sqw; set => sqw = value; }
        public string Actype { get => actype; set => actype = value; }
        internal FlightType Ft { get => ft; set => ft = value; }
    }
}
