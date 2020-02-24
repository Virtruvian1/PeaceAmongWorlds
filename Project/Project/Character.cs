using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class Character
    {
        public string name;
        public int age;
        public int money;
        public string spaceship;
        public List<bool> artifact;
        public List<bool> mapPieces;
        public Character()
        {
            this.name = "Rick";
            this.age = 18;
            this.money = 1000;
            this.spaceship = "Alpha";
            this.artifact = new List<bool>() { false, false, false, false, false };
            this.mapPieces = new List<bool>() { true, true, true    , true  , true };
        }








    }
}
