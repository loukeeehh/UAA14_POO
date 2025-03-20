using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT12_POO.Classes
{
    internal class Portion
    {
        private Liquide _contenu;
        private double _quantite;

        public Portion(Liquide contenu, double quantite)
        {
            _contenu = contenu;
            _quantite = quantite;
        }

        public Liquide Contenu
        {
            get { return _contenu; }
            set { _contenu = value; }
        }

        public double Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }


    }
}
