using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GameEngine();
          
        }

        public void GameEngine()
        {
            var Animation = new Animation();
            var Menu = new MenuFrames();
            MenuLink MenuLink = new MenuLink();
            bool runGame = true;
            var Draw = new Draw();
            var Movement = new Movement(MenuLink);
            Console.CursorVisible = false;
            int age = 0;

            Console.SetWindowSize(150, 40);
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\menu.txt");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Draw.DrawPlanets(MenuLink);
                Draw.DrawStatusBar(MenuLink);

                age = Movement.MovementHandle();

                



            } while (age < 75);

            Console.Clear();
            Console.WriteLine("You are Dead.\n");
            
            Animation.Animate("D:\\Documents\\MSSA\\C#\\PeaceAmongWorlds\\shockedmorty.txt");

            Console.ReadKey();

        }
    }
}
