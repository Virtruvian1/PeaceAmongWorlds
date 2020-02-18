using System;

namespace PeaceAmongWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGame = true;
            var Draw = new Draw();
            var Movement = new Movement();
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Draw.DrawPlanets();
                Draw.DrawStatusBar();
                
                Movement.MovementHandle();
            } while (runGame);
        }



    }
}
