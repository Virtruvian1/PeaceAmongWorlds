using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceAmongWorlds
{

    class Movement
    {
        public int currentX;
        public int currentY;
        public int targetX;
        public int targetY;
        public int ship;
        public int ageCounter = 0;

        public void MovementHandle()
        {
            var Draw = new Draw();
            InitialHandle();


            void InitialHandle()
            {
                int counter = ageCounter;
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
                do
                {
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
                            ++counter;
                            ageCounter = counter;
                            waitForKey = false;
                            continue;
                        case ConsoleKey.UpArrow:
                            --targetY;
                            PrevDraw();
                            continue;
                        case ConsoleKey.DownArrow:
                            ++targetY;
                            PrevDraw();
                            continue;
                        case ConsoleKey.LeftArrow:
                            --targetX;
                            PrevDraw();
                            continue;
                        case ConsoleKey.RightArrow:
                            PrevDraw();
                            ++targetX;
                            continue;
                        default:
                            break;
                    }

                } while (waitForKey);
            }

        }

        public void PrevDraw()
        {
            var Draw = new Draw();
            Console.Clear();
            Draw.DrawPlanets();
            Draw.DrawStatusBar();
            Draw.CurrentPosition(currentX, currentY, 3);
            Draw.TargetPosition(currentX, currentY, targetX, targetY, 3);
        }
        // For Development
        public void StatusID(int statusID)
        {
            int statusx = Console.CursorLeft;
            int statusy = Console.CursorTop;
            Console.SetCursorPosition(2, 38);
            Console.Write($"StatusID: {statusID}");
            Console.SetCursorPosition(statusx, statusy);
            Console.Read();
        }

    }
}
