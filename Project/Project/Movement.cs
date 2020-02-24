using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{

    class Movement
    {
        MenuLink MenuLink;

        public int currentX;
        public int currentY;
        public int targetX;
        public int targetY;

        public int yMin;
        public int yMax;
        public int xMin;
        public int xMax;

        public int xLowerLimit = 0;
        public int xUpperLimit = 149;
        public int yLowerLimit = 4;
        public int yUpperLimit = 39;

        public int ship = 6;
        public int ageCounter = 18;

        public int cursorPositionx;
        public int cursorPositiony;

        public Movement(MenuLink menuLink)
        {
            MenuLink = menuLink;
        }

        public int MovementHandle()
        {
            var Draw = new Draw();
            int age = InitialHandle();


            int InitialHandle()
            {

                if (ageCounter == 18)
                {
                    // Default (X, Y) from Earth
                    this.currentX = 75;
                    this.currentY = 15;
                    this.targetX = 75;
                    this.targetY = 15;
                    Draw.CurrentPosition(currentX, currentY, MenuLink.currentShip);
                }
                
                bool waitForKey = true;
                this.yMin = currentY - (MenuLink.spaceships[MenuLink.currentShip].speed); // Up
                this.yMax = currentY + (MenuLink.spaceships[MenuLink.currentShip].speed); // Down
                this.xMin = currentX - (MenuLink.spaceships[MenuLink.currentShip].speed + 1); // Left
                this.xMax = currentX + (MenuLink.spaceships[MenuLink.currentShip].speed + 1); // Right
                    
                do
                {
                    DisplayPostion();
                    DisplayCounter();
                    Draw.CurrentPosition(currentX, currentY, MenuLink.currentShip);
                    ConsoleKey keyPress = Console.ReadKey(true).Key;
                    switch (keyPress)
                    {
                        case ConsoleKey.M:
                            MenuLink.InventoryMenu();
                            waitForKey = false;
                            continue;
                        case ConsoleKey.S:
                            waitForKey = false;
                            continue;
                        case ConsoleKey.C:
                            waitForKey = false;
                            continue;
                        case ConsoleKey.Enter:
                            currentX = targetX;
                            currentY = targetY;
                            ++ageCounter;
                            int age = MenuLink.MenuLinks(currentX, currentY);
                            ageCounter += age;
                            waitForKey = false;
                            continue;
                        case ConsoleKey.UpArrow:
                            if (targetY > yLowerLimit)
                            {
                                if (targetY > yMin)
                                {
                                    this.targetY--;
                                    ArrowCall();
                                }
                            }
                            else
                            {
                                LimitMessage();
                            }
                            continue;
                        case ConsoleKey.DownArrow:
                            if (targetY < yUpperLimit)
                            {
                                if (targetY < yMax)
                                {
                                    this.targetY++;
                                    ArrowCall();
                                }
                            }
                            else
                            {
                                LimitMessage();
                            }
                            continue;
                        case ConsoleKey.LeftArrow:
                            if (targetX > xLowerLimit)
                            {
                                if (targetX > xMin)
                                {
                                    this.targetX--;
                                    ArrowCall();
                                }
                            }
                            else
                            {
                                LimitMessage();
                            }
                            continue;
                        case ConsoleKey.RightArrow:
                            if (targetX < xUpperLimit)
                            {
                                if (targetX < xMax)
                                {
                                    this.targetX++;
                                    ArrowCall();
                                }
                            }
                            else
                            {
                                LimitMessage();
                            }
                            continue;
                        default:
                            break;
                    }

                } while (waitForKey);


                return ageCounter;
            }

            return age;

        }

        public void ArrowCall()
        {
            var Draw = new Draw();
            Console.Clear();
            Draw.DrawPlanets(MenuLink);
            Draw.DrawStatusBar(MenuLink);
            Draw.CurrentPosition(currentX, currentY, MenuLink.spaceships[MenuLink.currentShip].speed);
            Draw.TargetPosition(currentX, currentY, targetX, targetY, MenuLink.spaceships[MenuLink.currentShip].speed);
        }

        public void DisplayCounter()
        {
            cursorPositionx = Console.CursorLeft;
            cursorPositiony = Console.CursorTop;
            Console.SetCursorPosition(97, 2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Age: {ageCounter}");
            Console.ResetColor();
            Console.SetCursorPosition(cursorPositionx, cursorPositiony);
        }
        public void LimitMessage()
        {
            cursorPositionx = Console.CursorLeft;
            cursorPositiony = Console.CursorTop;
            Console.SetCursorPosition(97, 4);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("WARNING! LIMIT REACHED!");
            Console.ResetColor();
            Console.SetCursorPosition(cursorPositionx, cursorPositiony);
        }

        public void DisplayPostion()
        {
            cursorPositionx = Console.CursorLeft;
            cursorPositiony = Console.CursorTop;
            Console.SetCursorPosition(97, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Current Postion ( {currentX}, {currentY} )");
            Console.SetCursorPosition(97, 1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Target Postion  ( {targetX}, {targetY} )");
            Console.ResetColor();
            Console.SetCursorPosition(cursorPositionx, cursorPositiony);
        }
    }
}
