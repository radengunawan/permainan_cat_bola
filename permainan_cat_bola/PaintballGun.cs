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
        private int balls = 100;
        private int ballsLoaded = 0;

        public int GetBallsLoaded()               //--------------------------------   
        { return this.ballsLoaded; }             //When the game requires 
                                                // to show the amount of 
        public bool IsEmpty()                   // remaining balls and the number       
        { return this.ballsLoaded == 0; }       // of balls loaded in the UI, it

        //public int GetBalls()                   // is able to summon the GetBalls and
        //{ return this.balls; }                  // GetBallsLoaded methods.
        //                                        //---------------------------------

        //public void SetBalls(int numberOfBalls)
        //{
        //    if (numberOfBalls > 0)
        //        this.balls = numberOfBalls; // The game wants to be capable to arrange the amount of balls.
        //    Reload();                       // The SetBalls method secure the balls field by only
        //}                                   // permitting the game to arrange a positive number of balls.
        //                                    // Then it summons Reload to automatically reload the gun.

        public int Bollaz
        {
            get { return balls; }
            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }


        public void Reload()                       // The only way to refill the gun is to summon the
        {                                           // Reload method, which fills the gun with a
            if (this.balls > MAGAZINE_SIZE)         // full magazine, or the  number of balls
                this.ballsLoaded = MAGAZINE_SIZE;   // left if there isn’t a full magazine’s worth.
            else                                    // This protects the balls and ballsLoaded fields
                this.ballsLoaded = this.balls;      // from being async.
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
