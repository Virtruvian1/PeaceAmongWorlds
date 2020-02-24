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

        public int MechanicMenu(ref int characterMoney, ref int spaceshipHealth, int maxHealth)
        {
            int time = 0;
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
                            
                            Console.WriteLine($"Spaceship repair cost: {healPrice}\n\nTime required (Years): {repairTime}\n\nAre you sure you want to continue?:    1. Yes\n" +
                                "                                       2. No");

                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    {
                                        if (spaceshipHealth != maxHealth)
                                        {

                                            // change spaceship health
                                            characterMoney -= healPrice;
                                            spaceshipHealth = maxHealth;
                                            time = repairTime;                                           
                                            Console.Clear();
                                            Console.WriteLine("Success! Your Spaceship has been repaired! (Press any key to continue...)");
                                            Console.ReadKey();
                                            
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Your Spaceship does not need repair! (Press any key to continue...)");
                                            Console.ReadKey();
                                        }

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

            return time;
        }
        public void ShopHealth(int spaceships, int maxHealth)
        {


            // Initilize variables
            int realCurrentHealth = spaceships; // <- Pull Variable from Ship Status
            int realTotalHealth = maxHealth;
            int statusCurrentHealth;
            int statusTotalHealth = 20;
            // Set Position
            CursorTo(1, 11);
            // Use proportion to calculate CurrentHealth for display
            statusCurrentHealth = (statusTotalHealth * realCurrentHealth) / realTotalHealth;
            // Expand string for display
            string displayHealth = new string(' ', statusCurrentHealth);
            // Displays Health status in Red
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"{displayHealth}");
            // Caluclate Missing Health
            int statusMissingHealth = statusTotalHealth - statusCurrentHealth;
            string displayMissingHealth = new string(' ', statusMissingHealth);
            // Fills Missing Health in Gray
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write($"{displayMissingHealth}");
            Console.ResetColor();
            // Display Health in Text
            CursorTo(1, 10);
            Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
            CursorTo(0, 0);
        }
        public void CursorTo(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

    }
}
