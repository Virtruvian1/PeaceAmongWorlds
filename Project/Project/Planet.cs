using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PeaceAmongWorlds
{
    // Version 1.0
    class Planets
    {
        public string Name;
        public int X1;
        public int X2;
        public int X3;
        public int X4;
        public int Y1;
        public int Y2;


        public Planets(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
        {
            this.Name = Name;
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
            this.Y1 = Y1;
            this.Y2 = Y2;
        }
    }
}
