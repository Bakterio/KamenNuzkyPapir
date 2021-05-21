using System;

namespace KamenNuskyPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            bool koncit = false;
            while (!koncit)
            {
                Console.WriteLine("Zadjete vaší volbu (kamen, nuzky, papir), (konec) pro ukončení programu");
                var strVolba = Console.ReadLine();
                int volba = 5;
                switch (strVolba)
                {
                    case ("kamen"):
                        volba = 0;
                        break;
                    case ("nuzky"):
                        volba = 1;
                        break;
                    case ("papir"):
                        volba = 2;
                        break;
                    case ("konec"):
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Zadali jste neplatnou možnost! Zkuste to znovu");
                        string[] neco = { "heh", "jej" };
                        Main(neco);
                        break;
                }
                Random random = new Random();
                int oponent = random.Next(0, 3);
                switch (oponent)
                {
                    case (0):
                        Console.WriteLine("Oponent dal Kámen.");
                        break;
                    case (1):
                        Console.WriteLine("Oponent dal Nůžky.");
                        break;
                    case (2):
                        Console.WriteLine("Oponent dal Papír.");
                        break;
                }
                if (oponent == volba)
                {
                    Console.WriteLine("Oba jste dali stejné věci, zkuste to znovu...");
                    string[] neco = { "heh", "jej" };
                    Main(neco);
                    break;
                }
                else if (oponent == 0 && volba == 1)
                {
                    prohra();
                }
                else if (oponent == 0 && volba == 2)
                {
                    vyhra();
                }
                else if (oponent == 1 && volba == 0)
                {
                    vyhra();
                }
                else if (oponent ==  1 && volba == 2)
                {
                    prohra();
                }
                else if (oponent == 2 && volba == 0)
                {
                    prohra();
                }
                else if (oponent == 2 && volba == 1)
                {
                    vyhra();
                }
                else
                {
                    Console.WriteLine("Chyba");
                }
            }
        }
        public static void vyhra()
        {
            Console.WriteLine("Vyhrál si.");
        }
        public static void prohra()
        {
            Console.WriteLine("Vyhrál oponent");
        }
    }
}