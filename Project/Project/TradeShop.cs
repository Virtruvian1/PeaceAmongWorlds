using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class TradeShop
    {
        public int coalPrice;
        public int goldPrice;
        public int diamondPrice;
        public int emeraldPrice;
        public int waterPrice;


        public TradeShop(int coalPrice, int goldPrice, int diamondPrice, int emeraldPrice, int waterPrice)
        {
            this.coalPrice = coalPrice;
            this.goldPrice = goldPrice;
            this.diamondPrice = diamondPrice;
            this.emeraldPrice = emeraldPrice;
            this.waterPrice = waterPrice;
        }




        public void TradeMenu(ref int characterMoney, ref List<int> inventory, ref int currentShip)
        {
            int bravoCost = 100;
            int charlieCost = 250;
            //Console.CursorVisible = false;
            //var keyInfo = Console.ReadKey(true).Key;
            bool tradeMenu = true;
            do
            {

                Console.Write($"             Welcome to the Local Shop\n\n" +
                "What would you like to do?:      1. Buy\n" +
                "                                 2. Sell\n" +
                "                                 3. Leave Shop\n");

                //var userInput = int.Parse(Console.ReadLine());
                //Console.Clear();
                switch (Console.ReadKey(true).Key)
                {



                    case ConsoleKey.D1: //Buy
                        {
                            bool buyDone = true;
                            Console.Clear();
                            do
                            {

                                Console.Write("Spaceship Shop Collection\n\n");

                                Console.WriteLine("1. Spaceship Bravo,   Cost:              100\n" +
                                    "                      Speed:             4\n" +
                                    "                      Health:            150\n" +
                                    "                      Light Damage:      12\n" +
                                    "                      Heavy Damage:      24\n" +
                                    "                      Ult Damage:        90\n" +
                                    "                      Cargo Space:       30\n\n" +
                                    "      ^ \n" +
                                    "    { A } \n" +
                                    "   <|||||>\n");
                                Console.WriteLine("2. Spaceship Charlie, Cost:              250\n" +
                                    "                      Speed:             6\n" +
                                    "                      Health:            200\n" +
                                    "                      Damage:            18\n" +
                                    "                      Heavy Damage:      30\n" +
                                    "                      Ult Damage:        120\n" +
                                    "                      Cargo Space:       40\n\n" +
                                    "      ^ \n" +
                                    "    { B } \n" +
                                    "   (( X ))\n" +
                                    "  <|||||||>\n");
                                Console.Write("What would you like to buy?:        1. Spaceship Bravo\n" +
                                    "                                    2. Spaceship Charlie\n" +
                                    "                                    3. Leave Shop\n");

                                switch (Console.ReadKey(true).Key)
                                {



                                    case ConsoleKey.D1:
                                        {
                                            if (characterMoney >= bravoCost && currentShip != 1)
                                            {
                                                // Add spaceshipBravo to character spaceship

                                                characterMoney -= bravoCost;
                                                currentShip = 1;
                                                Console.Clear();
                                                Console.WriteLine("Success! You now own Spaceship Bravo! (Press any key to continue..)");
                                                Console.ReadKey();

                                                buyDone = true;
                                                tradeMenu = false;
                                                break;



                                            }
                                            else if (currentShip == 1)
                                            {
                                                Console.Clear();
                                                Console.Write("You already own this Spaceship! (Press any key to return...) ");
                                                Console.ReadKey();
                                                Console.Clear();

                                                buyDone = false;
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.Write("Insuficient Funds, Press any key to return: ");
                                                Console.ReadKey();
                                                Console.Clear();

                                                buyDone = false;
                                                break;
                                            }

                                        }
                                    case ConsoleKey.D2:
                                        {
                                            if (characterMoney >= charlieCost && currentShip != 2)
                                            {
                                                // Add spaceshipCharlie to character spaceship

                                                characterMoney -= charlieCost;
                                                currentShip = 2;
                                                Console.Clear();
                                                Console.WriteLine("Success! You now own Spaceship Charlie! (Press any key to continue..)");
                                                Console.ReadKey();
                                                break;
                                            }
                                            else if (currentShip == 2)
                                            {
                                                Console.Clear();
                                                Console.Write("You already own this Spaceship! (Press any key to return...) ");
                                                Console.ReadKey();
                                                Console.Clear();

                                                buyDone = false;
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.Write("Insuficient Funds. (Press any key to return...) ");
                                                Console.ReadKey();
                                                Console.Clear();

                                                buyDone = false;
                                                break;
                                            }
                                        }
                                    case ConsoleKey.D3:
                                        {
                                            buyDone = true;
                                            tradeMenu = false;
                                            break;

                                        }
                                }

                            } while (!buyDone);
                            break;

                        }
                    case ConsoleKey.D2: //Sell
                        {
                            var sellDone = true;
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Item:    Current Market Value:        Your Inventory\n" +
                                    $"Coal          ${coalPrice}                          {inventory.ElementAt(0)}\n" +
                                    $"Gold          ${goldPrice}                          {inventory.ElementAt(1)}\n" +
                                    $"Diamond       ${diamondPrice}                          {inventory.ElementAt(2)}\n" +
                                    $"Emerald       ${emeraldPrice}                          {inventory.ElementAt(3)}\n" +
                                    $"Water         ${waterPrice}                          {inventory.ElementAt(4)}\n");
                                Console.Write("What item would you like to sell?:           1. Coal\n" +
                                              "                                             2. Gold\n" +
                                              "                                             3. Diamond\n" +
                                              "                                             4. Emerald\n" +
                                              "                                             5. Water\n" +
                                              "                                             6. Exit\n");
                                //string userMineral = Console.ReadLine();

                                switch (Console.ReadKey(true).Key)
                                {



                                    case ConsoleKey.D1:
                                        {
                                            var coalDone = true;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Coal\n" +
                                                    $"Current value per unit:     {coalPrice}\n" +
                                                    $"Your current units of Coal: {inventory.ElementAt(0)}\n");
                                                Console.Write("How many units would you like to sell? (Enter 00 to cancel): ");
                                                int coalSellUnits = int.Parse(Console.ReadLine());
                                                if (coalSellUnits <= inventory.ElementAt(0) && coalSellUnits > 0)
                                                {

                                                    int profit = coalSellUnits * coalPrice;
                                                    inventory[0] = inventory.ElementAt(0) - coalSellUnits;
                                                    characterMoney += profit;
                                                    coalDone = false;


                                                }
                                                else if (coalSellUnits > inventory.ElementAt(0))
                                                {
                                                    Console.Clear();
                                                    Console.Write("You don't have enough Coal, Press any key to return: ");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    coalDone = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    coalDone = true;
                                                    sellDone = false;
                                                }

                                            } while (!coalDone);
                                            break;

                                        }
                                    case ConsoleKey.D2:
                                        {
                                            var goldDone = true;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Gold\n" +
                                                    $"Current value per unit:     {goldPrice}\n" +
                                                    $"Your current units of Gold: {inventory.ElementAt(1)}\n");
                                                Console.Write("How many units would you like to sell? (Enter 00 to cancel): ");
                                                int goldSellUnits = int.Parse(Console.ReadLine());
                                                if (goldSellUnits <= inventory.ElementAt(1) && goldSellUnits > 0)
                                                {

                                                    int profit = goldSellUnits * goldPrice;
                                                    inventory[1] = inventory.ElementAt(1) - goldSellUnits;
                                                    characterMoney += profit;
                                                    goldDone = false;


                                                }
                                                else if (goldSellUnits > inventory.ElementAt(1))
                                                {
                                                    Console.Clear();
                                                    Console.Write("You don't have enough Gold, Press any key to return: ");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    goldDone = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    goldDone = true;
                                                    sellDone = false;
                                                }

                                            } while (!goldDone);
                                            break;

                                        }
                                    case ConsoleKey.D3:
                                        {
                                            var diamondDone = true;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Diamond\n" +
                                                    $"Current value per unit:     {diamondPrice}\n" +
                                                    $"Your current units of Diamond: {inventory.ElementAt(2)}\n");
                                                Console.Write("How many units would you like to sell? (Enter 00 to cancel): ");
                                                int diamondSellUnits = int.Parse(Console.ReadLine());
                                                if (diamondSellUnits <= inventory.ElementAt(2) && diamondSellUnits > 0)
                                                {

                                                    int profit = diamondSellUnits * diamondPrice;
                                                    inventory[2] = inventory.ElementAt(2) - diamondSellUnits;
                                                    characterMoney += profit;
                                                    diamondDone = false;


                                                }
                                                else if (diamondSellUnits > inventory.ElementAt(2))
                                                {
                                                    Console.Clear();
                                                    Console.Write("You don't have enough Diamond, Press any key to return: ");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    diamondDone = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    diamondDone = true;
                                                    sellDone = false;
                                                }

                                            } while (!diamondDone);
                                            break;

                                        }
                                    case ConsoleKey.D4:
                                        {
                                            var emeraldDone = true;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Emerald\n" +
                                                    $"Current value per unit:     {emeraldPrice}\n" +
                                                    $"Your current units of Emerald: {inventory.ElementAt(3)}\n");
                                                Console.Write("How many units would you like to sell? (Enter 00 to cancel): ");
                                                int emeraldSellUnits = int.Parse(Console.ReadLine());
                                                if (emeraldSellUnits <= inventory.ElementAt(3) && emeraldSellUnits > 0)
                                                {

                                                    int profit = emeraldSellUnits * emeraldPrice;
                                                    inventory[3] = inventory.ElementAt(3) - emeraldSellUnits;
                                                    characterMoney += profit;
                                                    emeraldDone = false;


                                                }
                                                else if (emeraldSellUnits > inventory.ElementAt(3))
                                                {
                                                    Console.Clear();
                                                    Console.Write("You don't have enough Emerald, Press any key to return: ");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    emeraldDone = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    emeraldDone = true;
                                                    sellDone = false;
                                                }

                                            } while (!emeraldDone);
                                            break;

                                        }
                                    case ConsoleKey.D5:
                                        {
                                            var waterDone = true;
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Water\n" +
                                                    $"Current value per unit:     {waterPrice}\n" +
                                                    $"Your current units of Water: {inventory.ElementAt(4)}\n");
                                                Console.Write("How many units would you like to sell? (Enter 00 to cancel): ");
                                                int waterSellUnits = int.Parse(Console.ReadLine());
                                                if (waterSellUnits <= inventory.ElementAt(4) && waterSellUnits > 0)
                                                {

                                                    int profit = waterSellUnits * waterPrice;
                                                    inventory[4] = inventory.ElementAt(4) - waterSellUnits;
                                                    characterMoney += profit;
                                                    waterDone = false;


                                                }
                                                else if (waterSellUnits > inventory.ElementAt(4))
                                                {
                                                    Console.Clear();
                                                    Console.Write("You don't have enough Water, Press any key to return: ");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                    waterDone = false;
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    waterDone = true;
                                                    sellDone = false;
                                                }

                                            } while (!waterDone);
                                            break;

                                        }
                                    case ConsoleKey.D6:
                                        {
                                            sellDone = true;
                                            tradeMenu = false;
                                            break;
                                        }
                                }

                            } while (!sellDone);
                            break;

                        }
                    case ConsoleKey.D3: //Exit
                        {
                            tradeMenu = true;
                            break;
                        }
                }
                Console.Clear();
            } while (!tradeMenu);
            //return inventory;


        }




    }
}
