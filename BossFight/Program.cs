using System;

namespace BossFight
{
    class Program
    {
        static void Main(string[] args)
        {

            GameCharacter player = new GameCharacter("Hero", 100);

            // Simulate a hit to HP:
            player.Health.Value = 25;

            player.AboutMe();

            Console.WriteLine("The boss you are looking for is in another dungeon..."); // FIXME: Remove when any form of gameplay is actually implemented.
        }
    }
}
