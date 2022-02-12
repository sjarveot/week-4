using System;

namespace LoopsandRandomsNumberkolmkatset
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab " Tere tulemast";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab"Vale Pin. Proovi uuesti;
            //kasutajal on kolm katset.

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere Tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud");

                }
                
              
                

                
            }



            


            Console.WriteLine("Kena päeva");
        }
    }
}
