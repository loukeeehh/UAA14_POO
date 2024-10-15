namespace I2P624_LoukaConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etats et couleurs des feux :");
            Console.WriteLine("----------------------------\n");
            Feux mesFeux = new Feux();
            int nbreFeux1 = 1001;
            int nbreFeux2 = 007;
            int nbAlternance = 5;
            int[] Feux = new int[2];

            Console.WriteLine("Le feu de signalisation " + nbreFeux1 + " est ");
            Console.WriteLine("Le feu de signalisation " + nbreFeux2 + " est \n");

            Console.WriteLine("Faire passer le " + nbreFeux2 + " à l'orange :");
            Console.WriteLine("----------------------------------\n");


            Console.WriteLine("Feu clignotant : ");
            Console.WriteLine("----------------------------\n");

        }
    }
}