using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class MechanicShop
    {
        int healPrice;
        int repairTime;
        public MechanicShop(int healPrice, int repairTime)
        {
            this.healPrice = healPrice;
            this.repairTime = repairTime;
        }

        public void MechanicMenu(ref int characterMoney, ref int spaceshipHealth, int maxHealth)
        {
            var mechanicMenu = false;
            do
            {

                Console.WriteLine("             Welcome to the Spaceship Repair Shop\n\n" +
                "What would you like to do?:      1. Repair Ship\n" +
                "                                 2. Leave\n");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.WriteLine($"Spaceship repair cost: {healPrice}\n\nTime required: {repairTime}\n\nAre you sure you want to continue?:    1. Yes\n" +
                                "                                       2. No");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    {

                                        // change spaceship health
                                        characterMoney -= healPrice;
                                        spaceshipHealth = maxHealth;
                                        Console.Clear();
                                        Console.WriteLine("Success! Your Spaceship has been repaired! (Press any key to continue...)");
                                        Console.ReadKey();

                                        Console.Clear();
                                        break;
                                    }
                                case ConsoleKey.D2:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                            }
                            break;

                        }
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            mechanicMenu = true;
                            break;
                        }

                }



            } while (!mechanicMenu);
        }

    }
}
