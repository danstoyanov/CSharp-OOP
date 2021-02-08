using P03_Raiding.Models;
using System;

namespace P03_Raiding
{
    public class StartUp
    {
        static void Main()
        {
            var druid = new Druid("Pesho", 32);
            var paladin = new Druid("Milo", 32);
            var rogue = new Druid("Chilo", 32);
            var warrior = new Druid("Shilo", 32);

            Console.WriteLine(druid.ToString());
            Console.WriteLine(paladin.ToString());
            Console.WriteLine(rogue.ToString());
            Console.WriteLine(warrior.ToString());

        }
    }
}
