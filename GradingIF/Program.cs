using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab suurepärane"
            //kui "B" , konsool kuvab "Väga hea"
            //"C" , konsool kuvab "Hea"
            //"D" , konsool kuvab " Rahuldav"
            //"E" , konsool kuvab "´Kasin"
            //"F" , Konsool kuvab "Puudulik"

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if(userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if(userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if(userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Vale väärtus");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
