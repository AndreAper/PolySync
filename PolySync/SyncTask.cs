using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySync
{
    public class SyncTask
    {
        public string Name { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public int Interval { get; set; }

        public TimeSpan Time { get; set; }

        public bool Enabled { get; set; }
    }
}
