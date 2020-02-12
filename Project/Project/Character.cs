using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Character
    {
        public string name;
        public int age;
        public int money;

        public Character(string name, int age, int money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }

        Character Rick = new Character("Rick", 18, 50);



    }
}
