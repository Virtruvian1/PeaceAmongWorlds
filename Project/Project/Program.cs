using System;

namespace PeaceAmongWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGame = true;
            do
            {
                Draw Draw = new Draw();
                Draw.DrawPlanets();
                Draw.DrawStatusBar();
                Console.Read();
            } while (!runGame);
        }
    }
}
