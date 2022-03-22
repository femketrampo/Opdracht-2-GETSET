using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_2
{
    class Breuk
    {
        private double teller;
        private double noemer;

        public double Teller
        {
            get { return teller; }
            set { teller = value; }
        }

        public double Noemer
        {
            get { return noemer; }
            set { noemer = value; }
        }

        public Breuk()
        {
            teller = 4;
            noemer = 4;
        }
        public Breuk(double Teller, double Noemer)
        {
            teller = Teller;
            noemer = Noemer;
        }
    }
}
