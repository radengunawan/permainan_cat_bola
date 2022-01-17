using System;
using System.Collections.Generic;
using System.Text;

namespace permainan_cat_bola
{
    class PaintballGun
    {
        //We’ll keep this constant public because
        //it’s going to be used by the Main method.
        public const int MAGAZINE_SIZE = 16;  // We’ll keep this constant public because
                                             //it’s going to be used by the Main method
        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded()               //--------------------------------   
        { return this.ballsLoaded; }             //When the game needs 
                                                // to display the number of 
        public bool IsEmpty()                   // balls left and the number       
        { return this.ballsLoaded == 0; }       // of balls loaded in the UI, it

        public int GetBalls()                   // can call the GetBalls and
        { return this.balls; }                  // GetBallsLoaded methods.
                                                //---------------------------------

        public void SetBalls(int numberOfBalls)
        {
            if (numberOfBalls > 0)
                this.balls = numberOfBalls; // The game needs to be able to set the number of balls.
            Reload();                       // The SetBalls method protects the balls field by only
        }                                   // allowing the game to set a positive number of balls.
                                            // Then it calls Reload to automatically reload the gun.

        private void Reload()                       // The only way to reload the gun is to call the
        {                                           // Reload method, which loads the gun with a
            if (this.balls > MAGAZINE_SIZE)         // full magazine, or the remaining number of
                this.ballsLoaded = MAGAZINE_SIZE;   // balls if there isn’t a full magazine’s worth.
            else                                    // This keeps the balls and ballsLoaded fields
                this.ballsLoaded = this.balls;      // from getting out of sync.
        }


        public bool Shoot()
        {

            if (ballsLoaded == 0) return false;
            this.ballsLoaded--;                     // The Shoot method returns true
            this.balls--;                           // and decrements the balls field if
            return true;                            // the gun is loaded, or false if it isn’t.
        }

    }
}
