using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzATC_WF.src
{
    public class Session
    {
        private string airport, vid;

        public Session(string airport, string vid)
        {
            this.airport = airport;
            this.vid = vid;
        }

        public string Airport
        {
            get
            {
                return airport;
            }

            set
            {
                airport = value;
            }
        }

        public string Vid
        {
            get
            {
                return vid;
            }

            set
            {
                vid = value;
            }
        }
    }
}
