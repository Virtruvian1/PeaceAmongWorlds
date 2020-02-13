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
            do
            {
                Draw.DrawPlanets();
                Draw.DrawStatusBar();
                Movement.MovementHandle();
                Console.Read();
            } while (!runGame);
        }
    }
}
