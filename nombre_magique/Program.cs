using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre(int NOMBRE_MIN, int NOMBRE_MAX)
        {
                int nombreUtilisateur = NOMBRE_MIN -1;

            while (nombreUtilisateur == 0) {
                Console.Write($"Rentrez un nombre entre {NOMBRE_MIN} et {NOMBRE_MAX}: ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);
                    if ((nombreUtilisateur < 1) || (nombreUtilisateur > 10))
                    {
                        nombreUtilisateur = 0;
                        Console.WriteLine($"ERREUR: Votre nombre n'est pas compris entre {NOMBRE_MIN} et {NOMBRE_MAX}");
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : Rentrez un nombre valide");
                }
            }

            return nombreUtilisateur;
        }


        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            Random rand = new Random();
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX +1);

            int nombre = NOMBRE_MAGIQUE + 1;

            int nbVies = 4;


            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (nombre > NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else if (nombre < NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else
                {
                    // Pour intérrompre l'itération
                    break;
                }
                nbVies--;
            }

            if (nombre == NOMBRE_MAGIQUE)
            {
                Console.WriteLine($"Bravo, vous avez trouvé le nombre magique! Il vous restait {nbVies} vie");
            }
            else
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était: " + NOMBRE_MAGIQUE);
            }


/*
            Random rand = new Random();

            for (int i = 0; i < 11;  i++)
            {
                int valeurAléatoire = rand.Next(1, 11);
                Console.WriteLine(valeurAléatoire);
            }
*/

        }
    }

}