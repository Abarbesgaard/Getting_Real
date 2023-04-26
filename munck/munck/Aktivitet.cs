using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munck
{
    public class Aktivitet
    {
        // Definer felter
        private Maskine _maskine;
        private double _time;
        private bool _aktiv;

        // Definer properties ud fra felterne
        public Maskine Maskine
        {
            get { return _maskine; }
            set { _maskine = value; }
        }

        public double Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public bool Aktiv
        {
            get { return _aktiv; }
            set { _aktiv = value; }
        }

        // Constructor
        public Aktivitet(Maskine maskine)
        {
            Maskine = maskine;
            Time = 0;
            Aktiv = true;
        }
    }
}
