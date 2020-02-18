using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGame = true;
            var Draw = new Draw();
            var Movement = new Movement();
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Draw.DrawPlanets();
                Draw.DrawStatusBar();

                Movement.MovementHandle();
                Program p = new Program();
                p.GameEngine();

            } while (runGame);
        }

        public void GameEngine()
        {



            Character Rick = new Character();
            //Spaceship RickShip = new Spaceship();
            var characterMoney = Rick.money;
            List<int> mainInventory = new List<int>() { 15, 10, 5, 3, 2 };


            int currentPlanet = 0;
            int currentEnemy = 0;
            int currentShip = 0;

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
                    Name = "Klendathu",
                    Leader = new Leader("Johnny Rico", "-----------\nHey soldier, glad you're here. We got a distress call from a Federation outpost on" +
                    " Planet P!\nWe need you to go to there and destroy any bugs in your way.\nBring back any survivors and in return I'll give you" +
                    "the Map Piece you're looking for...\nRemember... The only good bug is a dead bug!\n\n" , false, "Good job out there, you saved a life!\n" +
                    "You can join Rico's Roughnecks anyday.\n" +
                    "Anyway, heres your map piece."),
                    Mechanic = new MechanicShop(100, 100),
                    Shop = new TradeShop(3, 4, 6, 8, 8)
                },
                new Planet // 4
                {
                    Name = "Lavatory",
                    Leader = new Leader("Tony", "----\nI need you to track down this on planet Waititi and bring it back.\nIn return I'll give you" +
                    " the map piece you're looking for." , false, "Here's your map piece"),
                    Mechanic = new MechanicShop(150, 50),
                    Shop = new TradeShop(1, 2, 3, 4, 5)
                }
            };

            var mainEnemy = new List<Enemy>
            {
                    new Enemy // index 0
                {
                    Name = "LV-223", // Enemy 1
                    eLeader = "Xenomorph",
                    eGreeting = "~'Screeeeeeech'~....... (It looks like the Xenomorph is protecting the mineral artifact you need.)",
                    enemyHealth = 100,
                    enemyDamage = 10,
                    enemySpeed = 55,
                    enemyLoot = new List<int>() {5, 2 , 1 , 2 , 1}

                },
                      new Enemy // index 1
                {
                    Name = "Hoth", // Enemy 2
                    eLeader = "Wampa",
                    eGreeting = "~'Roooarrrr'~....... (It looks like the Wampa is protecting the Lightsaber artifact you need.)",
                    enemyHealth = 150,
                    enemyDamage = 20,
                    enemySpeed = 75,
                    enemyLoot = new List<int>() {8, 2 , 4 , 2 , 6}

                },
                      new Enemy // index 2
                {
                    Name = "Planet P", // Enemy 3
                    eLeader = "Bug",
                    eGreeting = "~'Scary Bug Noise'~....... (It looks like there is one survivor left. Protect him from the bug!)",
                    enemyHealth = 180,
                    enemyDamage = 30,
                    enemySpeed = 100,
                    enemyLoot = new List<int>() {2, 8 , 2 , 4 , 1}

                },
                      new Enemy // index 3
                {
                    Name = "Waititi", // Enemy 4
                    eLeader = "Glootie",
                    eGreeting = "The enemy has the artifact you need!",
                    enemyHealth = 200,
                    enemyDamage = 40,
                    enemySpeed = 100,
                    enemyLoot = new List<int>() {8, 1 , 1 , 1 , 9}

                },
            };

            var rickShip = new List<Spaceship>
            {
                    new Spaceship // Alpha
                {
                    shipName = "Alpha",
                    speed = 50,
                    health = 100,
                    maxHealth = 100,
                    lightDamage = 10,
                    heavyDamage = 20,
                    ult = 60,
                    cargoSpace = 20

                },
                    new Spaceship // Bravo
                {
                    shipName = "Bravo",
                    speed = 75,
                    health = 150,
                    maxHealth = 150,
                    lightDamage = 12,
                    heavyDamage = 24,
                    ult = 90,
                    cargoSpace = 30

                },
                    new Spaceship // Charlie
                {
                    shipName = "Charlie",
                    speed = 100,
                    health = 200,
                    maxHealth = 200,
                    lightDamage = 18,
                    heavyDamage = 30,
                    ult = 120,
                    cargoSpace = 40

                }
            };

            var enemyMenu = false;
            var planetMenu = false;


            PlanetMenu(Rick, rickShip, ref mainInventory, currentPlanet, planets, planetMenu, ref currentShip);
            CombatMenu(Rick, ref mainInventory, currentPlanet, currentEnemy, currentShip, mainEnemy, rickShip, enemyMenu);
        }

        private static bool CombatMenu(Character Rick, ref List<int> mainInventory, int currentPlanet, int currentEnemy, int currentShip, List<Enemy> mainEnemy, List<Spaceship> rickShip, bool enemyMenu)
        {
            do
            {
                Console.CursorVisible = false;
                Console.WriteLine($"Planet {mainEnemy[currentEnemy].Name}\n\n" +
                mainEnemy[currentEnemy].eLeader + "\n\n" +
                mainEnemy[currentEnemy].eGreeting + "\n\n" +
                "What would you like to do?:          1. Fight\n" +
                "                                     2. Run\n");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        {
                            int ultimate = 0;
                            int turn = 0;
                            var combatMenu = false;
                            Console.Clear();
                            do
                            {

                                if (mainEnemy[currentEnemy].enemyHealth > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Enemy: {mainEnemy[currentEnemy].eLeader}\n\nStats\nDamage: {mainEnemy[currentEnemy].enemyDamage}\n" +
                                        $"Health: {mainEnemy[currentEnemy].enemyHealth}\n\nYour Stats\nLight Damage: {rickShip[currentShip].lightDamage}\n" +
                                        $"Heavy Damage: {rickShip[currentShip].heavyDamage}\n" +
                                        $"Ult Damage: {rickShip[currentShip].ult}\n" +
                                        $"Health: {rickShip[currentShip].health}\nUltimate Charge: {ultimate} out of 5\n\n");

                                    Random rand = new Random();
                                    int proba = rand.Next(1, 101);
                                    if (turn == 0)
                                    {
                                        Console.WriteLine("It's your turn. What would you like to do?:       1. Light Laser Attack\n" +
                                                          "                                                  2. Heavy Missile Attack\n" +
                                                          "                                                  3. Charge Ultimate\n" +
                                                          "                                                  4. Use Ultimate");
                                        switch (Console.ReadKey(true).Key)
                                        {
                                            case ConsoleKey.D1:
                                                {

                                                    if (proba <= 60)
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= rickShip[currentShip].lightDamage;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack hit hard! {mainEnemy[currentEnemy].eLeader} took {rickShip[currentShip].lightDamage} damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= (rickShip[currentShip].lightDamage / 2);
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack was partially deflected! {mainEnemy[currentEnemy].eLeader} took {(rickShip[currentShip].lightDamage / 2)} damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;
                                                    }


                                                }
                                            case ConsoleKey.D2:
                                                {
                                                    if (proba <= 40)
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= rickShip[currentShip].heavyDamage;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack hit hard! {mainEnemy[currentEnemy].eLeader} took {rickShip[currentShip].heavyDamage} damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= 0;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack was dodged! {mainEnemy[currentEnemy].eLeader} took 0 damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;
                                                    }



                                                }
                                            case ConsoleKey.D3:
                                                {
                                                    if (proba <= 70)
                                                    {
                                                        ultimate++;
                                                        if (ultimate < 5)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"You charged your ultimate.\nUltimate Charge: {ultimate} out of 5. (Press any key to continue...)");
                                                            Console.ReadKey();
                                                            turn++;
                                                            break;
                                                        }
                                                        else if (ultimate == 5)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"Your ultimate will be ready to use next attack phase!\nUltimate Charge: {ultimate} out of 5. (Press any key to continue...)");
                                                            Console.ReadKey();
                                                            turn++;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine($"You can't charge your ultimate, its already charged! (Press any key to continue...)");
                                                            Console.ReadKey();
                                                            ultimate--;
                                                            break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        rickShip[currentShip].health -= 20;
                                                        Console.Clear();              
                                                        Console.WriteLine($"Charging Failed! You were attacked while charging your ultimate!\nYou took 20 damage!\nUltimate Charge: {ultimate} out of 5. (Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;
                                                    }


                                                }
                                            case ConsoleKey.D4:
                                                {
                                                    if (ultimate == 5)
                                                    {
                                                        if (proba < 70)
                                                        {
                                                            mainEnemy[currentEnemy].enemyHealth -= rickShip[currentShip].ult;
                                                            Console.Clear();
                                                            Console.WriteLine($"Your ultimate was a direct hit! {mainEnemy[currentEnemy].eLeader} took {rickShip[currentShip].ult} damage. (Press any key to continue...)");
                                                            Console.ReadKey();
                                                            ultimate = 0;
                                                            turn++;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            mainEnemy[currentEnemy].enemyHealth -= (rickShip[currentShip].ult / 2);
                                                            Console.Clear();
                                                            Console.WriteLine($"Your ultimate was partially defended! { mainEnemy[currentEnemy].eLeader} took {rickShip[currentShip].ult / 2} damage.(Press any key to continue...)");
                                                            Console.ReadKey();
                                                            ultimate = 0;
                                                            turn++;
                                                            break;
                                                        }
                                                    }

                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"You can't use your ultimate yet! (Press any key to continue...)");
                                                        Console.ReadKey();
                                                        break;
                                                    }



                                                }

                                        }




                                    }
                                    else
                                    {
                                        Console.WriteLine($"The enemy is attacking!. What would you like to do?:       1. Dodge\n" +
                                                           "                                                           2. Defend\n");
                                        switch (Console.ReadKey(true).Key)
                                        {
                                            case ConsoleKey.D1:
                                                {
                                                    if (proba <= 80)
                                                    {
                                                        rickShip[currentShip].health -= mainEnemy[currentEnemy].enemyDamage;
                                                        Console.Clear();
                                                        Console.WriteLine($"You couldn't dodge the attack in time! You took {mainEnemy[currentEnemy].enemyDamage} damage" +
                                                            $"(Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn--;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("You dodged the attack! You took 0 damage! (Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn--;
                                                        break;
                                                    }



                                                }
                                            case ConsoleKey.D2:
                                                {

                                                    if (proba <= 20)
                                                    {
                                                        rickShip[currentShip].health -= (mainEnemy[currentEnemy].enemyDamage - 5);
                                                        Console.Clear();
                                                        Console.WriteLine($"You defended, but the attack was strong! You took {mainEnemy[currentEnemy].enemyDamage - 5} damage" +
                                                            $"(Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn--;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        rickShip[currentShip].health -= (mainEnemy[currentEnemy].enemyDamage - 10);
                                                        Console.Clear();
                                                        Console.WriteLine($"You partially defended the attack! You took {mainEnemy[currentEnemy].enemyDamage - 10} damage" +
                                                            $"(Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn--;
                                                        break;
                                                    }


                                                }

                                        }

                                    }



                                }
                                else
                                {
                                    Console.Clear();


                                    Rick.artifact[currentPlanet] = true;
                                    mainInventory[0] += mainEnemy[currentEnemy].enemyLoot[0];
                                    mainInventory[1] += mainEnemy[currentEnemy].enemyLoot[1];
                                    mainInventory[2] += mainEnemy[currentEnemy].enemyLoot[2];
                                    mainInventory[3] += mainEnemy[currentEnemy].enemyLoot[3];
                                    mainInventory[4] += mainEnemy[currentEnemy].enemyLoot[4];
                                    //mainInventory = mainInventory.Zip(mainEnemy[currentEnemy].enemyLoot, (a, b) => (a + b));
                                    Console.WriteLine($"You successfully defeated {mainEnemy[currentEnemy].eLeader}!\n\nHere is your reward: \n\n" +
                                        $"1. Artifact #{currentPlanet}\n" +
                                        $"2. Coal:      {mainEnemy[currentEnemy].enemyLoot[0]}\n" +
                                        $"3. Gold:      {mainEnemy[currentEnemy].enemyLoot[1]}\n" +
                                        $"4. Diamond:   {mainEnemy[currentEnemy].enemyLoot[2]}\n" +
                                        $"5. Emerald:   {mainEnemy[currentEnemy].enemyLoot[3]}\n" +
                                        $"6. Water:     {mainEnemy[currentEnemy].enemyLoot[4]}\n");
                                    Console.ReadKey();
                                    combatMenu = true;
                                    enemyMenu = true;
                                }


                            } while (!combatMenu);





                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            if (rickShip[currentShip].speed < mainEnemy[currentEnemy].enemySpeed)
                            {
                                Console.Clear();
                                Console.WriteLine("Your ship is too slow, you can't run! (Press any key to continue...)");
                                Console.ReadKey();
                                Console.Clear();

                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You have successfully esacped. (Press any key to continue...)");
                                Console.ReadKey();
                                Console.Clear();
                                enemyMenu = true;
                                break;
                            }
                        }
                    default:
                        {
                            Console.Clear();
                            break;
                        }


                }


            } while (!enemyMenu);
            return enemyMenu;
        }

        private static void PlanetMenu(Character Rick, List<Spaceship> spaceships, ref List<int> mainInventory, int currentPlanet, List<Planet> planets, bool planetMenu, ref int currentShip)
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
                            planets[currentPlanet].Shop.TradeMenu(ref Rick.money, ref mainInventory, ref currentShip);
                            break;

                        }
                    case ConsoleKey.D3:
                        {
                            Console.Clear();
                            planets[currentPlanet].Mechanic.MechanicMenu(ref Rick.money, ref spaceships[currentShip].health, spaceships[currentShip].maxHealth);
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
