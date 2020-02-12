using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Planets
    {
        public Planets()
        {
        }


        
        public void Earth()
        {
            int ID = 1;
            int[] xCoords = new int[] {15, 16 };
            int[] yCoords = new int[] {17, 18 };
            DrawPlanet(ID, xCoords, yCoords);
        }

        public void Hoth()
        {
            int ID = 2;
            int[] xCoords = new int[] { 25, 26 };
            int[] yCoords = new int[] { 50, 51 };
        }
        
        public void LV426()
        {
            int ID = 3;
            int[] xCoords = new int[] { 25, 26 };
            int[] yCoords = new int[] { 50, 51 };
        }
        
        public void Naboo()
        {
            int ID = 4;
            int[] xCoords = new int[] { 25, 26 };
            int[] yCoords = new int[] { 50, 51 };
        }
        
        public void Tatooine()
        {
            int ID = 5;
            int[] xCoords = new int[] { 25, 26 };
            int[] yCoords = new int[] { 50, 51 };
        }



        public void DrawPlanet(int ID, int[] xCoords, int[] yCoords)
        {
            switch (ID)
            {
                case 1:
                    for (int x = 0; x < xCoords.Length; x++)
                    {
                        for (int y = 0; y < yCoords.Length; y++)
                        {
                            Console.SetCursorPosition(xCoords[x], yCoords[y]);
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("     ");
                            Console.ResetColor();
                        }
                    }
                        break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                default:
                    break;
            }
        }

    }
}
