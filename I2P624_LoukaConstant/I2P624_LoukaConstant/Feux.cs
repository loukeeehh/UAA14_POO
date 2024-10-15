using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P624_LoukaConstant
{
    internal class Feux
    {
        int _couleur;
        string _identifiant;
        bool _etat;
    }

    public bool Etat(bool etat)
    {
        get { return _etat; }
        set { _etat = value; }
    }

    
    public int ChangeCouleur()
    {
        
    }

    public bool ChangeEtat(bool Allume)
    {
        Allume = true;

        if (Allume)
        {
            Console.WriteLine("Le feu de signalisation est allumé");
        }

        else
        {
            Console.WriteLine("Le feu de signalisation est éteint");
        }

    }

    public void Clignote(int nbAlternance)
    {
        bool Allume = true;

        for (int i = 0; i < nbAlternance + 1; i++)
        {
            if (Allume)
            {
                Console.WriteLine("Le feu de signalisation est allumé");
            }    
        }


    }

    public string AfficheCouleur(int couleur)
    {

    }

    public string AfficheEtat()
    {

    }



}
