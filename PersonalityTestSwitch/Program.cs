using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;

                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
