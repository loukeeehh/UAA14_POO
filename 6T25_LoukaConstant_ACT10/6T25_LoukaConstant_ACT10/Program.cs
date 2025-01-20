using System.Diagnostics;

namespace _6T25_LoukaConstant_ACT10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue à la bibliothèque !");
            string repeatProg;
            
          
            Bibliotheque bibli = new Bibliotheque(); // Création de la bibliothèque

            Livre livre = new Livre("Le Hobbit", "Tolkien", 1);
            Console.WriteLine(livre.Description());
            //bibiliotheque.Add(livre);
            bibli.Ajoute(livre);
            
            Livre livre1 = new Livre("Le Seigneur Des Anneaux", "Tolkien", 5);
            Console.WriteLine(livre1.Description());
            bibli.Ajoute(livre1);

            Livre livre2 = new Livre("La légende Ludo Bechet", "Louka Constant", 3);
            Console.WriteLine(livre2.Description());
            bibli.Ajoute(livre2);

            Livre livre3 = new Livre("criminelle", "test0", 1);
            Console.WriteLine(livre3.Description());    
            bibli.Ajoute(livre3);

            Console.WriteLine("\nQue voulez-vous faire ?\n 1. Afficher l'inventaire de la bibliothèque\n 2. dégradation d'un livre\n");
            string nUser = Console.ReadLine();

            if (nUser == "1")
            {
                Console.WriteLine("Voici l'inventaire :");
                Console.WriteLine("---------------------------");
                Console.WriteLine(bibli.Inventaire());
            }

            if (nUser == "2")
            {
                Console.WriteLine("Dégradation");
                Console.WriteLine("-----------------------");

                do
                {

                    Console.WriteLine("Quelle livre voulez-vous dégrader ? livre 1,2,3 ou 4 ?");
                    string nUser1 = Console.ReadLine();

                    if (nUser1 == "1")
                    {
                        bibli.Livres[0].Degrade();
                    }

                    if (nUser1 == "2")
                    {
                        bibli.Livres[1].Degrade();
                    }

                    if (nUser1 == "3")
                    {
                        bibli.Livres[2].Degrade();
                    }

                    if (nUser1 == "4")
                    {
                        bibli.Livres[3].Degrade();
                    }

                    bibli.SupprimeLivresAbimes();
                    Console.WriteLine(bibli.Inventaire());

                    Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                    repeatProg = Console.ReadLine();

                    

                } while (repeatProg == "o");

                

                

            }

          
        }
    }
}