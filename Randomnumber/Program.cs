using System;

namespace Randomnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kui genereeritud number on 5, lõpetab konsool oma töö ja soovib "kena päeva"
            //kui genereeritud number on midagi muud,siis programm jätkab tööd

            Random rnd = new Random();
            int i = 0;

            while(i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
