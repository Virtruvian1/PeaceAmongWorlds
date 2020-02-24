using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Project
{
	public class MenuLink
	{
        public Character Rick = new Character();
        public Leader Leader = new Leader();
        public List<int> mainInventory = new List<int>() { 5, 3, 2, 3, 2 };
        public int currentShip = 0;
        public List<Planet> planets = new List<Planet>
            {
                new Planet // 0
                {
                    Name = "Earth",
                    Leader = new Leader("King Keanu", "----------\nGreetings Rick.There are strong dark forces at work in the universe.\n" +
                "My sources say they are building a large battleship to take over the galaxy.\n" +
                "A map to their battleship was broken into 4 pieces and scattered across 4 planets.\n" +
                "Find these pieces, Find the battleship and destroy it!\n\n" +
                "This is your home, you can always return here to Heal up.\nGOOD LUCK!'\n", false, "Stay away from my Dog..."),
                    Mechanic = new MechanicShop(0, 1),
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
                    Mechanic = new MechanicShop(80, 2),
                    Shop = new TradeShop(3, 6, 8, 7, 9)

                },
                new Planet // 2
                {
                    Name = "Tatooine",
                    Leader = new Leader("Sebulba", "-------\nYou look like you could use a new Pod Racer.. How 'bout it?\n" +
                    "I see, your here for a map piece. Well that will cost you a pretty penny.\n" +
                    "I'm looking for a lightsaber that belonged to a bratty kid I used to know..\n" +
                    "You should find it on a nearby planet. Go get it and I'll give you what you want.\n", false, "Give me the lightsaber and get lost..\nHere's your map piece.."),
                    Mechanic = new MechanicShop(120, 3),
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
                    Mechanic = new MechanicShop(100, 2),
                    Shop = new TradeShop(3, 4, 6, 8, 8)
                },
                new Planet // 4
                {
                    Name = "Lav",
                    Leader = new Leader("Tony", "----\nI need you to track down this on planet Waititi and bring it back.\nIn return I'll give you" +
                    " the map piece you're looking for." , false, "Here's your map piece"),
                    Mechanic = new MechanicShop(150, 2),
                    Shop = new TradeShop(1, 2, 3, 4, 5)
                }
            };
        public List<Enemy> mainEnemy = new List<Enemy>  
            {
                    new Enemy // index 0
                {
                    Name = "LV-223", // Enemy 1
                    eLeader = "Xenomorph",
                    eGreeting = "~'Screeeeeeech'~....... (It looks like the Xenomorph is protecting the mineral artifact you need.)",
                    enemyHealth = 100,
                    enemyMaxHealth = 100,
                    enemyDamage = 10,
                    enemySpeed = 1,
                    enemyLoot = new List<int>() {5, 2 , 1 , 2 , 1}

                },
                      new Enemy // index 1
                {
                    Name = "Hoth", // Enemy 2
                    eLeader = "Wampa",
                    eGreeting = "~'Roooarrrr'~....... (It looks like the Wampa is protecting the Lightsaber artifact you need.)",
                    enemyHealth = 150,
                    enemyMaxHealth = 150,
                    enemyDamage = 15,
                    enemySpeed = 1,
                    enemyLoot = new List<int>() {8, 2 , 4 , 2 , 6}

                },
                      new Enemy // index 2
                {
                    Name = "Planet P", // Enemy 3
                    eLeader = "Bug",
                    eGreeting = "~'Scary Bug Noise'~....... (It looks like there is one survivor left. Protect him from the bug!)",
                    enemyHealth = 180,
                    enemyMaxHealth = 180,
                    enemyDamage = 15,
                    enemySpeed = 4,
                    enemyLoot = new List<int>() {2, 8 , 2 , 4 , 1}

                },
                      new Enemy // index 3
                {
                    Name = "Waititi", // Enemy 4
                    eLeader = "Glootie",
                    eGreeting = "The enemy has the artifact you need!",
                    enemyHealth = 200,
                    enemyMaxHealth = 200,
                    enemyDamage = 20,
                    enemySpeed = 7,
                    enemyLoot = new List<int>() {8, 1 , 1 , 1 , 9}

                },
            };
        public List<Spaceship> spaceships = new List<Spaceship>
            {
                    new Spaceship // Alpha
                {
                    shipName = "Alpha",
                    speed = 2,
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
                    speed = 4,
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
                    speed = 6,
                    health = 200,
                    maxHealth = 200,
                    lightDamage = 18,
                    heavyDamage = 30,
                    ult = 120,
                    cargoSpace = 40

                }
            };
        public int currentPlanet = 0;
        public int currentEnemy = 0;


        public MenuLink()
		{
		}

		public int MenuLinks(int currentX, int currentY)
		{
            int time = 0;
            
			if ((currentX == 75 || currentX == 76 || currentX == 77 || currentX == 78) && (currentY == 15 || currentY == 16))
			{
                currentPlanet = 0; //Earth
                time = PlanetMenu();
               
			}

            if ((currentX == 27 || currentX == 28 || currentX == 29 || currentX == 30) && (currentY == 9 || currentY == 10))
            {
                currentPlanet = 1; //LV 426
                time = PlanetMenu();
            }

            if ((currentX == 100 || currentX == 101 || currentX == 102 || currentX == 103) && (currentY == 19 || currentY == 20))
            {
                currentPlanet = 2; //Tatooine
                time = PlanetMenu();
            }

            if ((currentX == 25 || currentX == 26 || currentX == 27 || currentX == 28) && (currentY == 23 || currentY == 24))
            {
                currentPlanet = 3; //Klendathu
                time = PlanetMenu();
            }

            if ((currentX == 65 || currentX == 66 || currentX == 67 || currentX == 68) && (currentY == 37 || currentY == 38))
            {
                currentPlanet = 4; //Lav
                time = PlanetMenu();
            }

            // Enemy Action
            if ((currentX == 27 || currentX == 28 || currentX == 29 || currentX == 30) && (currentY == 15 || currentY == 16) && planets[1].Leader.mission == true && Rick.artifact[1] == false)
            {
                currentEnemy = 0;
                time = CombatMenu();
            }
            if ((currentX == 100 || currentX == 101 || currentX == 102 || currentX == 103) && (currentY == 24 || currentY == 25) && planets[2].Leader.mission == true && Rick.artifact[2] == false)
            {
                currentEnemy = 1;
                time = CombatMenu();
            }
            if ((currentX == 33 || currentX == 34 || currentX == 35 || currentX == 36) && (currentY == 30 || currentY == 31) && planets[3].Leader.mission == true && Rick.artifact[3] == false)
            {
                currentEnemy = 2;
                time = CombatMenu();
            }
            if ((currentX == 80 || currentX == 81 || currentX == 82 || currentX == 83) && (currentY == 37 || currentY == 38) && planets[4].Leader.mission == true && Rick.artifact[4] == false)
            {
                currentEnemy = 3;
                time = CombatMenu();
            }
           
            // Death Star
            if ((currentX == 130 || currentX == 131 || currentX == 132 || currentX == 133) && (currentY == 5 || currentY == 6))
            {

                // Separate combat menu
                DeathStarCombat();

            }


            return time;

        }

        public int PlanetMenu()
        {
            int time = 0;
            var planetMenu = false;
            Console.Clear();
            do
            {
                Console.CursorVisible = false;
                MenuHealthBar();
                BottomOfMenu();
                RickInventory();
                CursorTo(0, 6);
                Console.WriteLine($"            Welcome to Planet {planets[currentPlanet].Name}\n\n" +
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
                           
                            time = planets[currentPlanet].Mechanic.MechanicMenu(ref Rick.money, ref spaceships[currentShip].health, spaceships[currentShip].maxHealth);
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

            return time;

        }

        public int CombatMenu()
        {
            int time = 0;
            var enemyMenu = false;
            Console.Clear();

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
                                
                                if (mainEnemy[currentEnemy].enemyHealth > 0 && spaceships[currentShip].health > 0)
                                {
                                    Console.Clear();
                                    CombatHealth();
                                    EnemyHealth();
                                    Console.WriteLine($"Enemy: {mainEnemy[currentEnemy].eLeader}\n\nStats\n-----\nDamage: {mainEnemy[currentEnemy].enemyDamage}\n\n\n\n" +
                                        $"Your Stats\n----------\nLight Damage: {spaceships[currentShip].lightDamage}\n" +
                                        $"Heavy Damage: {spaceships[currentShip].heavyDamage}\n" +
                                        $"Ult Damage: {spaceships[currentShip].ult}\n" +
                                        $"Ultimate Charge: {ultimate} out of 5\n\n");

                                    Random rand = new Random();
                                    int proba = rand.Next(1, 101);
                                    if (turn == 0)
                                    {
                                        Console.WriteLine("\nIt's your turn. What would you like to do?:       1. Light Laser Attack\n" +
                                                          "                                                  2. Heavy Missile Attack\n" +
                                                          "                                                  3. Charge Ultimate\n" +
                                                          "                                                  4. Use Ultimate");
                                        switch (Console.ReadKey(true).Key)
                                        {
                                            case ConsoleKey.D1:
                                                {

                                                    if (proba <= 60)
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= spaceships[currentShip].lightDamage;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack hit hard! {mainEnemy[currentEnemy].eLeader} took {spaceships[currentShip].lightDamage} damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= (spaceships[currentShip].lightDamage / 2);
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack was partially deflected! {mainEnemy[currentEnemy].eLeader} took {(spaceships[currentShip].lightDamage / 2)} damage. (Press any" +
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
                                                        mainEnemy[currentEnemy].enemyHealth -= spaceships[currentShip].heavyDamage;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack hit hard! {mainEnemy[currentEnemy].eLeader} took {spaceships[currentShip].heavyDamage} damage. (Press any" +
                                                            $" key to continue...)");
                                                        Console.ReadKey();
                                                        turn++;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        mainEnemy[currentEnemy].enemyHealth -= 10;
                                                        Console.Clear();
                                                        Console.WriteLine($"Your attack was partially dodged! {mainEnemy[currentEnemy].eLeader} took 10 damage. (Press any" +
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
                                                        spaceships[currentShip].health -= 5;
                                                        Console.Clear();
                                                        Console.WriteLine($"Charging Failed! You were attacked while charging your ultimate!\nYou took 5 damage!\nUltimate Charge: {ultimate} out of 5. (Press any key to continue...)");
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
                                                            mainEnemy[currentEnemy].enemyHealth -= spaceships[currentShip].ult;
                                                            Console.Clear();
                                                            Console.WriteLine($"Your ultimate was a direct hit! {mainEnemy[currentEnemy].eLeader} took {spaceships[currentShip].ult} damage. (Press any key to continue...)");
                                                            Console.ReadKey();
                                                            ultimate = 0;
                                                            turn++;
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            mainEnemy[currentEnemy].enemyHealth -= (spaceships[currentShip].ult / 2);
                                                            Console.Clear();
                                                            Console.WriteLine($"Your ultimate was partially defended! { mainEnemy[currentEnemy].eLeader} took {spaceships[currentShip].ult / 2} damage.(Press any key to continue...)");
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
                                                    if (proba <= 60)
                                                    {
                                                        spaceships[currentShip].health -= mainEnemy[currentEnemy].enemyDamage;
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
                                                        spaceships[currentShip].health -= (mainEnemy[currentEnemy].enemyDamage - 5);
                                                        Console.Clear();
                                                        Console.WriteLine($"You defended, but the attack was strong! You took {mainEnemy[currentEnemy].enemyDamage - 5} damage" +
                                                            $"(Press any key to continue...)");
                                                        Console.ReadKey();
                                                        turn--;
                                                        break;

                                                    }
                                                    else
                                                    {
                                                        spaceships[currentShip].health -= (mainEnemy[currentEnemy].enemyDamage - 10);
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

                                else if (spaceships[currentShip].health <= 0)
                                {
                                    turn = 100;
                                    combatMenu = true;
                                    enemyMenu = true;
                                }
                                else
                                {
                                    Console.Clear();

                                    var Animation = new Animation();
                                    Rick.artifact[currentPlanet] = true;
                                    mainInventory[0] += mainEnemy[currentEnemy].enemyLoot[0];
                                    mainInventory[1] += mainEnemy[currentEnemy].enemyLoot[1];
                                    mainInventory[2] += mainEnemy[currentEnemy].enemyLoot[2];
                                    mainInventory[3] += mainEnemy[currentEnemy].enemyLoot[3];
                                    mainInventory[4] += mainEnemy[currentEnemy].enemyLoot[4];
                                    //mainInventory = mainInventory.Zip(mainEnemy[currentEnemy].enemyLoot, (a, b) => (a + b));

                                    WinAnimation(Animation);

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


                            if(turn > 30 && turn <= 99)
                            {
                                time = 2;
                            }
                            else if (turn == 100)
                            {
                                time = 100;
                            }
                            else
                            {
                                time = 1; 
                            }


                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            if (spaceships[currentShip].speed < mainEnemy[currentEnemy].enemySpeed)
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
                                time = 1;
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

            return time;
           
        }

        private static void WinAnimation(Animation Animation)
        {
            for (int i = 0; i < 8; i++)
            {


                Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\tina1.txt");
                Thread.Sleep(30);
                Console.Clear();
                Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\tina2.txt");
                Thread.Sleep(30);
                Console.Clear();


            }
        }

        public void CombatHealth()
        {


            // Initilize variables
            int realCurrentHealth = spaceships[currentShip].health; // <- Pull Variable from Ship Status
            int realTotalHealth = spaceships[currentShip].maxHealth;
            int statusCurrentHealth;
            int statusTotalHealth = 20;
            // Set Position
            CursorTo(1, 15);
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
            CursorTo(1, 14);
            Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
            CursorTo(0, 0);
        }
        public void EnemyHealth()
        {


            // Initilize variables
            int realCurrentHealth = mainEnemy[currentEnemy].enemyHealth; // <- Pull Variable from Ship Status
            int realTotalHealth = mainEnemy[currentEnemy].enemyMaxHealth;
            int statusCurrentHealth;
            int statusTotalHealth = 20;
            // Set Position
            CursorTo(1, 6);
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
            CursorTo(1, 5);
            Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
            CursorTo(0, 0);
        }
        public void CursorTo(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        public void InventoryMenu()
        {
            CursorTo(40, 10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string bar1 = new string('-', 55);
            Console.Write(bar1);
            CursorTo(40, 20);            
            string bar2 = new string('-', 55);
            Console.Write(bar2);
            for (int i = 11; i < 20; i++)
            {
                CursorTo(40, i);               
                Console.WriteLine("|");
            }
            for (int i = 11; i < 20; i++)
            {
                CursorTo(94, i);               
                Console.WriteLine("|");
            }
            Console.ResetColor();
            CursorTo(60, 11);
            Console.WriteLine("Quest Progress");
            CursorTo(41, 13);
            Console.WriteLine("Planet Artifacts");
            CursorTo(41, 14);
            Console.WriteLine("----------------");
            CursorTo(41, 15);
            Console.WriteLine($"Artifact 1: {Rick.artifact[1]}");
            CursorTo(41, 16);
            Console.WriteLine($"Artifact 2: {Rick.artifact[2]}");
            CursorTo(41, 17);
            Console.WriteLine($"Artifact 3: {Rick.artifact[3]}");
            CursorTo(41, 18);
            Console.WriteLine($"Artifact 4: {Rick.artifact[4]}");
            CursorTo(73, 13);
            Console.WriteLine("Map Pieces");
            CursorTo(73, 14);
            Console.WriteLine("----------");
            CursorTo(73, 15);
            Console.WriteLine($"Map Piece 1: {Rick.mapPieces[1]}");
            CursorTo(73, 16);
            Console.WriteLine($"Map Piece 2: {Rick.mapPieces[2]}");
            CursorTo(73, 17);
            Console.WriteLine($"Map Piece 3: {Rick.mapPieces[3]}");
            CursorTo(73, 18);
            Console.WriteLine($"Map Piece 4: {Rick.mapPieces[4]}");




            Console.ReadKey();
        }
        public void RickInventory()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            CursorTo(30, 0);
            Console.Write("|");
            CursorTo(30, 1);
            Console.Write("|");
            CursorTo(30, 2);
            Console.Write("|");
            CursorTo(30, 3);
            Console.Write("|");
            CursorTo(95, 0);
            Console.Write("|");
            CursorTo(95, 1);
            Console.Write("|");
            CursorTo(95, 2);
            Console.Write("|");
            CursorTo(95, 3);
            Console.Write("|");
            Console.ResetColor();
            CursorTo(39, 0);
            Console.WriteLine($"Artifact 1: {Rick.artifact[1]}");
            CursorTo(39, 1);
            Console.WriteLine($"Artifact 2: {Rick.artifact[2]}");
            CursorTo(39, 2);
            Console.WriteLine($"Artifact 3: {Rick.artifact[3]}");
            CursorTo(39, 3);
            Console.WriteLine($"Artifact 4: {Rick.artifact[4]}");
            CursorTo(73, 0);
            Console.WriteLine($"Map Piece 1: {Rick.mapPieces[1]}");
            CursorTo(73, 1);
            Console.WriteLine($"Map Piece 2: {Rick.mapPieces[2]}");
            CursorTo(73, 2);
            Console.WriteLine($"Map Piece 3: {Rick.mapPieces[3]}");
            CursorTo(73, 3);
            Console.WriteLine($"Map Piece 4: {Rick.mapPieces[4]}");
            CursorTo(113, 0);
            Console.WriteLine("Your Inventory");
            CursorTo(103, 1);
            Console.WriteLine($"Coal:    {mainInventory.ElementAt(0)}");
            CursorTo(103, 2);
            Console.WriteLine($"Gold:    {mainInventory.ElementAt(1)}");
            CursorTo(103, 3);
            Console.WriteLine($"Diamond: {mainInventory.ElementAt(2)}");
            CursorTo(123, 1);
            Console.WriteLine($"Emerald: {mainInventory.ElementAt(3)}");
            CursorTo(123, 2);
            Console.WriteLine($"Water:   {mainInventory.ElementAt(4)}");

        }
        public void BottomOfMenu()
        {
            CursorTo(0, 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string bar = new string('R', 140);
            Console.Write($"{bar}" + "iicckk!!!!");
            Console.ResetColor();
        }
        public void MenuHealthBar()
        {
            // Initilize variables
            int realCurrentHealth = spaceships[currentShip].health; // <- Pull Variable from Ship Status
            int realTotalHealth = spaceships[currentShip].maxHealth;
            int statusCurrentHealth;
            int statusTotalHealth = 20;
            // Set Position
            CursorTo(2, 1);
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
            CursorTo(2, 0);
            Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
            CursorTo(2, 2);
            Console.WriteLine($"Money: {Rick.money}\n  Current Ship: {spaceships[currentShip].shipName}");
        }

        public void DeathStarCombat()
        {
            var Animation = new Animation();
            int time = 800;

            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\toxicrick.txt");
            Thread.Sleep(time);
            Console.Clear();
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\deathstar.txt");
            Thread.Sleep(time);
            Console.Clear();
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\fight.txt");
            Thread.Sleep(time);
            Console.Clear();
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\deathstar.txt");
            Thread.Sleep(time);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\explosion.txt");
            Thread.Sleep(time);
            Console.Clear();
            Console.ResetColor();
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\victory.txt");
            Thread.Sleep(time);
            Console.Clear();
            Console.WriteLine("You Win!");
            Console.ReadKey();



        }

    }

}