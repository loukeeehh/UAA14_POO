using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT10
{
    internal class Bibliotheque
    {
        private List<Livre> _livres;

		public List<Livre> Livres
		{
			get { return _livres; }
		}

		public Bibliotheque()
		{
			_livres = new List<Livre>(); // Création liste de livres
		}

		public void Ajoute(Livre livre)
		{
			_livres.Add(livre);
		}

		public void SupprimeLivresAbimes() // supprimer dans une liste
		{
			for(int i = 0; i < _livres.Count; i++)
			{
				if (_livres[i].Etat == 0) // Livres à tel placement dont l'état vaut 0
				{
                    _livres.RemoveAt(i);
                }
				
			}
		}

		public string Inventaire()
		{
			string infos = "";
			for (int i = 0; i < _livres.Count; i++)
			{
				infos += Livres[i].Auteur + " " + Livres[i].Titre + " " + Livres[i].Etat + "\n";
			}

			return infos;
		}

	}

}


