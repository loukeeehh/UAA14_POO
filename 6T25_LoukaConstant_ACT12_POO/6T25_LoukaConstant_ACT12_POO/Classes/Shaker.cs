using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT12_POO.Classes
{
    internal class Shaker
    {
        private List<Portion> _portions;
        private double _quantiteMax;
        bool _estPropre;

        public Shaker(List<Portion> portions, double quantite, bool estPropre)
        {
            _portions = portions;
            _quantiteMax = quantite;
            _estPropre = estPropre;
        }

        public List<Portion> Portions
        {
            get { return _portions; }
            set { _portions = value; }
        }

        public double QuantiteMax
        {
            get { return _quantiteMax; }
            set { _quantiteMax = value; }
        }


    }
}
