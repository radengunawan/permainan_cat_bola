using System;
using System.Collections.Generic;
using System.Text;

namespace permainan_cat_bola
{
    class PaintballGun
    {
        //We’ll keep this constant public because
        //it’s going to be used by the Main method.
        public const int MAGAZINE_SIZE = 16;

        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded()                   
        { return this.ballsLoaded; }                 //<---  When the game needs to display the number of
                                                    //<-- balls left and the number of balls loaded in the UI, it
        public bool IsEmpty() { return this.ballsLoaded == 0; } //<-- // can call the GetBalls and GetBallsLoaded methods.

        public int GetBalls() { return this.balls; }

        public void SetBalls(int numberOfBalls)
        {
            if (numberOfBalls > 0)
                this.balls = numberOfBalls; // The game needs to be able to set the number of balls.
            Reload();                       // The SetBalls method protects the balls field by only
        }                                   // allowing the game to set a positive number of balls.
                                            // Then it calls Reload to automatically reload the gun.

        private void Reload()
        {
            if (this.balls > MAGAZINE_SIZE)
                this.ballsLoaded = MAGAZINE_SIZE;
            else
                this.ballsLoaded = this.balls;
        }


        public bool Shoot()
        {

            if (ballsLoaded == 0) return false;
            this.ballsLoaded--;
            this.balls--;
            return true;
        }

    }
}
