using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT10
{
    internal class Livre 
    {
        private string _titre;
        private string _auteur;
        ushort _etat;

        public Livre(string titre, string auteur, ushort etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }

        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public ushort Etat
        {
            get { return _etat; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    _etat = value;
                }

                else
                {
                    _etat = 5;
                }
            }
        }

        public void Degrade()
        {
            if (_etat > 0)
            {
                _etat--;
            }

            else if (_etat == 0)
            {
                string infos = "Le livre est trop abimé et doit être retiré, voici son état : " + Etat;
            }
           
        }

        public string Description()
        {
            return "Le titre du livre est : " + Titre + ", l'auteur s'appelle : " + Auteur + ", " + Etat;
        }



    }
}
