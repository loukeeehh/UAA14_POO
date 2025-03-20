using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT12_POO.Classes
{
    internal class Recette
    {
        private List<Portion> _portions;

        public Recette(List<Portion> portions)
        {
            _portions = portions;
        }

        public List<Portion> Portions
        {
            get { return _portions; }
            set { _portions = value; }
        }

        public void ObtenirPortions()
        {

        }

    }
}
