using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class Leader
    {
        public string name;
        public string greeting;
        public bool mission;

        public Leader()
        {
            this.name = "King Keanu\n";
            this.greeting = "Greetings Rick. There are strong dark forces at work in the universe.\n" +
                "My sources say they are building a large battleship to take over the galaxy.\n" +
                "A map to their battleship was broken into 4 pieces and scattered across 4 planets.\n" +
                "Find these pieces, Find the battleship and destroy it!\n\n" +
                "This is your home, you can always return here to Heal up.\nGOOD LUCK!\n";
            this.mission = false;

        }



        public void LeaderMenu(ref bool mission)
        {
            Console.WriteLine(name);
            Console.WriteLine(greeting);
            Console.WriteLine("Would you like to accept this mission?:        1. Yes\n" +
                              "                                               2. No\n");
            Console.CursorVisible = false;
            var keyInfo = Console.ReadKey(true).Key;
            switch (keyInfo)
            {
                case ConsoleKey.D1:
                    {
                        if (mission == true)
                        {
                            Console.Clear();
                            Console.WriteLine("You have already accepted or completed this mission! (Press any key to continue...)");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            mission = true;
                            Console.Clear();
                            Console.WriteLine("Success! You unlocked a new planet to complete your mission. (Press any key to continue...)");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                    }
                case ConsoleKey.D2:
                    {
                        Console.Clear();
                        break;
                    }
                    
            }


        }



    }
}
