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
            List<int> mainInventory = new List<int>() { 15, 10, 5, 3, 2 };

            int currentPlanet = 0;

            var planets = new List<Planet>
            {
                new Planet // 0
                {
                    Name = "Earth",
                    Leader = new Leader(),
                    Mechanic = new MechanicShop(50, 200),
                    Shop = new TradeShop(1, 2, 3, 4, 5)
                },
                new Planet // 1
                {
                    Name = "LV-426",
                    Leader = new Leader("Ellen Ripley", "-----------\nHello traveler. Welcome to LV-426, its one hell of a planet.\nWatch your back, Xenomorphs are crawling" +
                    " all over the place.\nWe are building a weapon that might be able to destroy them once and for all, but we are missing a key mineral.\n" +
                    "There is a nearby planet with an abundance of the mineral we need.\n" +
                    "Go to that planet and bring us back that mineral.\n" +
                    "In return, I'll give you the map piece you are looking for....\n", false, "Wow, you actually survived huh..I'm impressed.\nWell, a deals a deal.\n" +
                    "Here's your map piece. Good Luck out there.\n"),
                    Mechanic = new MechanicShop(80, 100),
                    Shop = new TradeShop(3, 6, 8, 7, 9)

                },
                new Planet // 2
                {
                    Name = "Tatooine",
                    Leader = new Leader("Sebulba", "-------\nYou look like you could use a new Pod Racer.. How 'bout it?\n" +
                    "I see, your here for a map piece. Well that will cost you a pretty penny.\n" +
                    "I'm looking for a lightsaber that belonged to a bratty kid I used to know..\n" +
                    "You should find it on a nearby planet. Go get it and I'll give you what you want.\n", false, "Give me the lightsaber and get lost..\nHere's your map piece.."),
                    Mechanic = new MechanicShop(120, 250),
                    Shop = new TradeShop(2, 2, 1, 4, 8)
                },
                new Planet // 3
                {
                    Name = "",
                    Leader = new Leader(),
                    Mechanic = new MechanicShop(50, 200),
                    Shop = new TradeShop(1, 2, 3, 4, 5)
                },
                new Planet // 4
                {
                    Name = "",
                    Leader = new Leader(),
                    Mechanic = new MechanicShop(50, 200),
                    Shop = new TradeShop(1, 2, 3, 4, 5)
                }
            };

            var planetMenu = false;
            PlanetMenu(Rick, RickShip, ref mainInventory, currentPlanet, planets, ref planetMenu);

        }

        private static void PlanetMenu(Character Rick, Spaceship RickShip, ref List<int> mainInventory, int currentPlanet, List<Planet> planets, ref bool planetMenu)
        {
            do
            {
                Console.CursorVisible = false;
                Console.WriteLine($"             Welcome to Planet {planets[currentPlanet].Name}\n\n" +
                "What would you like to do?:      1. Take me to your Leader\n" +
                "                                 2. Local Shop\n" +
                "                                 3. Spaceship Mechanic\n" +
                "                                 4. Leave Planet\n");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            planets[currentPlanet].Leader.LeaderMenu(ref planets[currentPlanet].Leader.mission, ref Rick.artifact, ref Rick.mapPieces, currentPlanet);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            planets[currentPlanet].Shop.TradeMenu(ref Rick.money, ref mainInventory);
                            break;

                        }
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            planets[currentPlanet].Mechanic.MechanicMenu(ref Rick.money, ref RickShip.health);
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
        }
    }
}
