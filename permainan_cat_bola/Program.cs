using System;

namespace permainan_cat_bola
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintballGun senpi = new PaintballGun();

            while (true)
            {
                Console.WriteLine($"{senpi.GetBalls()} balls, {senpi.GetBallsLoaded()} loaded.");

                if (senpi.IsEmpty()) Console.WriteLine("DANGER!. You're out of ammo");
                Console.WriteLine ("Shoot=Space, Reload = r, Quit = q");

                char khoonci = Console.ReadKey(true).KeyChar;

                if (khoonci == ' ') Console.WriteLine($"Shooting returned {senpi.Shoot()}");

                else if (khoonci == 'r') senpi.Reload();

                else if (khoonci == '+') senpi.SetBalls(senpi.GetBalls() + PaintballGun.MAGAZINE_SIZE);

                else if (khoonci == 'q') return;
                













            }
        }
    }
}
