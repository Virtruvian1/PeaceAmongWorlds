using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GameEngine();
            
        }
        public void GameEngine()
        {
            
            

            Character Rick = new Character();
            Spaceship RickShip = new Spaceship();
            var characterMoney = Rick.money;
            List<int> mainInventory = new List<int>() { 1, 2, 3, 4, 5 };

            Leader EarthLeader = new Leader();
            MechanicShop EarthMechanic = new MechanicShop(50, 200);
            TradeShop EarthShop = new TradeShop(1, 2, 3, 4, 5);

            var planetMenu = false;
            do
            {
                Console.CursorVisible = false;
                Console.WriteLine("             Welcome to Planet Earth\n\n" +
                "What would you like to do?:      1. Take me to your Leader\n" +
                "                                 2. Local Shop\n" +
                "                                 3. Spaceship Mechanic\n" +
                "                                 4. Leave Planet\n");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                    {
                            Console.Clear();
                            EarthLeader.LeaderMenu(ref EarthLeader.mission);
                                break;
                    }
                    case ConsoleKey.D2:
                    {
                            Console.Clear();
                            EarthShop.TradeMenu(ref Rick.money, ref mainInventory);
                                break;

                    }
                    case ConsoleKey.D3:
                    {
                            Console.Clear();
                            EarthMechanic.MechanicMenu(ref Rick.money, ref RickShip.health);
                                break;
                    }
                    case ConsoleKey.D4:
                    {
                            Console.Clear();
                            planetMenu = true;
                                break;
                    }
                    default:
                        {
                            Console.Clear();
                            break;
                        }
                }

            } while (!planetMenu);

            
            
            Console.WriteLine(Rick.money);
            Console.WriteLine(mainInventory.ElementAt(4));
            Console.WriteLine(RickShip.shipName);
        }
    }
}
