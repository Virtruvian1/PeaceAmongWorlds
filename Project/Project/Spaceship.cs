using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class Spaceship
    {
        public string shipName;
        public int speed;
        public int health;
        public int damage;
        public int cargoSpace;


        public Spaceship ()
        {
            this.shipName = "Alpha";
            this.speed = 50;
            this.health = 100;
            this.damage = 10;
            this.cargoSpace = 20;
        }
        public Spaceship(string shipName, int speed, int health, int damage, int cargoSpace)
        {
            this.shipName = shipName;
            this.speed = speed;
            this.health = health;
            this.damage = damage;
            this.cargoSpace = cargoSpace;
                 
        }





    }
}
