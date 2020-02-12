using System;
using System.Collections.Generic;
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
                                    
        


        public void TradeMenu(int characterMoney)
        {
            int bravoCost = 100;
            int charlieCost = 250;
           
            bool loopMenu = true;
            do
            {

                Console.Write("Would you like to Buy or Sell or Leave: ");
                string userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "Buy")
                {
                    bool done = true;

                    do
                    {

                        Console.Write("Please select which spaceship you would like to buy, 1 or 2: \n\n");

                        Console.WriteLine("1. Spaceship Bravo, Cost: 100\n\n" +
                            "      ^ \n" +
                            "    { A } \n" +
                            "   <|||||>\n");
                        Console.WriteLine("2. Spaceship Charlie, Cost: 250\n\n" +
                            "      ^ \n" +
                            "    { B } \n" +
                            "   (( X ))\n" +
                            "  <|||||||>\n");
                        Console.Write("Enter Your Selection, 1 or 2 (Enter 3 to cancel): ");
                        int userPurchase = int.Parse(Console.ReadLine());
                        if (userPurchase == 1)
                        {
                            if (characterMoney >= bravoCost)
                            {
                                // Add spaceshipBravo to character spaceship
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("Insuficient Funds, Press any key to return: ");
                                Console.ReadKey();
                                Console.Clear();

                                done = false;
                            }

                        }
                        else if (userPurchase == 2)
                        {
                            if (characterMoney >= charlieCost)
                            {
                                // Add spaceshipBravo to character spaceship
                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("Insuficient Funds, Press any key to return: ");
                                Console.ReadKey();
                                Console.Clear();

                                done = false;
                            }
                        }
                        else
                        {
                            loopMenu = false;
                            break;

                        }

                    } while (!done);


                }
                else if (userInput == "Sell")
                {
                    Console.WriteLine("Current Item Value: \n" +
                        $"Coal:    {coalPrice}\n" +
                        $"Gold:    {goldPrice}\n" +
                        $"Diamond: {diamondPrice}\n" +
                        $"Emerald: {emeraldPrice}\n" +
                        $"Water:   {waterPrice}\n");
                    Console.Write("What item would you like to sell?: ");
                    string userMineral = Console.ReadLine();
                    if (userMineral == "Coal")
                    {
                        Console.Clear();
                        Console.WriteLine($"Coal\n " +
                            $"Current value per unit:    {coalPrice}\n" +
                            $"Your current units of Coal: 0\n");
                        Console.Write("How many units would you like to sell?: ");
                        int coalSellUnits = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    loopMenu = true;
                }
                Console.Clear();
            } while (!loopMenu);


        }




    }
}
