using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceAmongWorlds
{
    class Planets
    {
        public Planets()
        {
        }



        public (int[], int[], int) Earth()
        {
            int ID = 1;
            int[] xCoords = new int[] { 50, 51 };
            int[] yCoords = new int[] { 24, 25 };
            return (xCoords, yCoords, ID);
        }

        public (int[], int[], int) Hoth()
        {
            int ID = 2;
            int[] xCoords = new int[] { 27, 28 };
            int[] yCoords = new int[] { 9, 10 };
            return (xCoords, yCoords, ID);
        }

        public (int[], int[], int) LV426()
        {
            int ID = 3;
            int[] xCoords = new int[] { 15, 16 };
            int[] yCoords = new int[] { 19, 20 };
            return (xCoords, yCoords, ID);
        }

        public (int[], int[], int) Naboo()
        {
            int ID = 4;
            int[] xCoords = new int[] { 25, 26 };
            int[] yCoords = new int[] { 39, 40 };
            return (xCoords, yCoords, ID);
        }

        public (int[], int[], int) Tatooine()
        {
            int ID = 5;
            int[] xCoords = new int[] { 65, 66 };
            int[] yCoords = new int[] { 37, 38 };
            return (xCoords, yCoords, ID);
        }

        public (int[], int[], int) DeathStar()
        {
            int ID = 6;
            int[] xCoords = new int[] { 90, 91, 92, 93 };
            int[] yCoords = new int[] { 5, 6, 7, 8 };
            return (xCoords, yCoords, ID);
        }



    }
}
