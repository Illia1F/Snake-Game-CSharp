using System;

namespace Snake__Game_Logic
{
    internal class Ball : Map
    {
        private static bool countBall = true;

        private Random random;

        public Point Position;

        public Ball(int width, int height)
        {
            if (!Ball.countBall)
                throw new OutOfMemoryException("A Ball object is allowed to create only once!");
            Ball.countBall = false;

            this.width = width;
            this.height = height;

            random = new Random();

            // generate a new ball
            GetANextBall();
        }

        public void GetANextBall()
        {
            Position = new Point(random.Next(1, width), random.Next(1, height));
        }
    }
}
