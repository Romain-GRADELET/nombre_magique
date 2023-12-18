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


            int nombreTest = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
            Console.WriteLine("Votre nombre est: " + nombreTest);

        }
    }
}