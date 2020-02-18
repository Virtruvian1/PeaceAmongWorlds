using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{

    class Movement
    {
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
        public int ageCounter;

        public int cursorPositionx;
        public int cursorPositiony;


        public void MovementHandle()
        {
            var Draw = new Draw();
            InitialHandle();


            void InitialHandle()
            {

                if (ageCounter == 0)
                {
                    // Default (X, Y) from Earth
                    this.currentX = 75;
                    this.currentY = 15;
                    this.targetX = 75;
                    this.targetY = 15;
                    Draw.CurrentPosition(currentX, currentY, 3);
                }
                
                bool waitForKey = true;
                this.yMin = currentY - (ship + 1); // Up
                this.yMax = currentY + (ship + 1); // Down
                this.xMin = currentX - (ship + 1); // Left
                this.xMax = currentX + (ship + 1); // Right
                
                do
                {
                    DisplayPostion();
                    DisplayCounter();
                    Draw.CurrentPosition(currentX, currentY, 3);
                    ConsoleKey keyPress = Console.ReadKey(true).Key;
                    switch (keyPress)
                    {
                        case ConsoleKey.M:
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
                            var MenuLink = new MenuLink();
                            MenuLink.MenuLinks(currentX, currentY);
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
            }

        }

        public void ArrowCall()
        {
            var Draw = new Draw();
            Console.Clear();
            Draw.DrawPlanets();
            Draw.DrawStatusBar();
            Draw.CurrentPosition(currentX, currentY, ship);
            Draw.TargetPosition(currentX, currentY, targetX, targetY, ship);
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
