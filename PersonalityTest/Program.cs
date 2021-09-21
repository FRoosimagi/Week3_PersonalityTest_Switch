using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada lemmiku värvi
            // kui kasutaja sisestab punase, konsool kuvab "oled romantiline"
            //kui kasutaja sisestab sinise, konsool kuvab "oled töökas"
            //kui rohelise, konsool kuvab "oled looduse sõber"
            // kui midagi muud, konsool kuvab "oled {userColor} üksarvik

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if(userColor == "roheline"){
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
