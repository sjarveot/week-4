using System;

namespace guessinggameinfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit vaid ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int guess;
            bool gameOver = false;

                Console.WriteLine("Arva number ühe ja kümne vahel:");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess != cpuNumber)
                {
                    Console.WriteLine("Vale number, proovi veel");
                    gameOver = false;

                }

                else if (guess == cpuNumber)
                {
                 Console.WriteLine("Palju õnne õige number.");
                 gameOver = true;
                        
                }
              

            }

            
               
        }
    }
}
