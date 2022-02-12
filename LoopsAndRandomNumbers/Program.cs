using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab " Tere tulemast";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab"Vale Pin. Proovi uuesti;
            

            Console.WriteLine("Sisesta PIN:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN == 1234)
            {
                Console.WriteLine("Tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti");
            }
            Console.WriteLine("Kena päeva");
        }
    }
}
