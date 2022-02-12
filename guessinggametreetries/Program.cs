using System;

namespace guessinggametreetries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata siis mängu võidab arvuti
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int guess;
            bool gameOver = false;
            int i = 0;

            Console.WriteLine("Arva ära number 1 ja 10 vahel:");
            while (i < 3)
            {
                
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == cpuNumber)
                {
                    Console.WriteLine("Palju õnne õige number");
                    gameOver = true;

                }

                if (guess != cpuNumber)
                {
                    i = i + 1;
                    Console.WriteLine($"Vale number. {3 - i} katset in jäänud.");
                    gameOver = false;
                }







            }
        }
    }
}
