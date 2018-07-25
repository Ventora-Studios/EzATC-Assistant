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

        public string Actype
        {
            get
            {
                return actype;
            }

            set
            {
                actype = value;
            }
        }

        public string Callsign
        {
            get
            {
                return callsign;
            }

            set
            {
                callsign = value;
            }
        }

        public string Departure
        {
            get
            {
                return departure;
            }

            set
            {
                departure = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public string Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
            }
        }

        public string Sqw
        {
            get
            {
                return sqw;
            }

            set
            {
                sqw = value;
            }
        }

        internal FlightType Ft
        {
            get
            {
                return ft;
            }

            set
            {
                ft = value;
            }
        }

        public String getFirstFix()
        {
            return "ABTAL";
        }

        public String getLastFix()
        {
            return "KOPAG";
        }
    }
}
