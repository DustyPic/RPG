using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Game
    {
    }
    class Item
    {
    }
    class Program
    {
        static void Main()
        {
            string CharacterName = "Tundmatu";
            Console.WriteLine("Mängunimi");
            Console.WriteLine("Mängukirjeldus");
            Console.WriteLine("Sisesta tegelase nimi");

            CharacterName = Console.ReadLine();

            Console.WriteLine("Sinu tegelasenimi on nüüd " + CharacterName + "!");

            Console.ReadKey();
        }
    }
}
