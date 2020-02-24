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
            MenuLink MenuLink = new MenuLink();
            bool runGame = true;
            var Draw = new Draw();
            var Movement = new Movement(MenuLink);
            Console.CursorVisible = false;
            int age = 0;

            Console.SetWindowSize(140, 50);
            Animation.Animate("..\\..\\..\\..\\.\\..\\docs\\Animations\\Menu\\menu.txt");
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
            
            Animation.Animate("..\\..\\..\\..\\..\\docs\\Animations\\ShockedMorty\\Shocked Morty.txt");
            
            Console.ReadKey();

        }
    }
}
