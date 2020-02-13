using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceAmongWorlds
{

    class Movement
    {
        public int PositionX;
        public int PositionY;
        public int TargetX;
        public int TargetY;
        public int ID;
        public void MovementHandle()
        {
            this.PositionX = 15;
            this.PositionY = 25;
            TargetX = PositionX;
            TargetY = PositionY;
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            switch (keyPress)
            {
                case ConsoleKey.UpArrow:
                    ID = 1;
                    ArrowHandle(ID);
                    break;
                case ConsoleKey.DownArrow:
                    ID = 2;
                    ArrowHandle(ID);
                    break;
                case ConsoleKey.LeftArrow:
                    ID = 3;
                    ArrowHandle(ID);
                    break;
                case ConsoleKey.RightArrow:
                    ID = 4;
                    ArrowHandle(ID);
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.S:
                    break;
                default:
                    break;
            }

            void ArrowHandle( int ID)
            {
                bool move = true;
                do
                {
                    Console.SetCursorPosition(TargetX, TargetY);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    switch (ID)
                    {
                        case 1:
                            --TargetY;
                            break;
                        case 2:
                            ++TargetY;
                            break;
                        case 3:
                            --TargetX;
                            break;
                        case 4:
                            ++TargetX;
                            break;
                        default:
                            break;
                    }
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" ");
                    Console.ResetColor();

                    ConsoleKey keyPress = Console.ReadKey(true).Key;
                    switch (keyPress)
                    {
                        case ConsoleKey.UpArrow:
                            ID = 1;
                            continue;
                        case ConsoleKey.DownArrow:
                            ID = 2;
                            continue;
                        case ConsoleKey.LeftArrow:
                            ID = 3;
                            continue;
                        case ConsoleKey.RightArrow:
                            ID = 4;
                            continue;
                        case ConsoleKey.Enter:
                            PositionX = TargetX;
                            PositionY = TargetY;
                            move = true;
                            break;
                        default:
                            break;
                    }


                    } while (move);
            }
        }

        
    }
}