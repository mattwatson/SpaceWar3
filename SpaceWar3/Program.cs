using System;

namespace SpaceWar3
{
    public static class Program
    {

        [STAThread]
        static void Main()
        {
            using (var game = new SpaceWar3())
                game.Run();
        }
    }
}
