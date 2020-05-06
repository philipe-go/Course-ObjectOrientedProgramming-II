using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncingBalls.business
{
    abstract class Ball //internal as default to be used inside the same namespace
    {
        protected int radius; //protected to be used by child classes
        protected Point center;
        protected Point velocity;

        protected Ball(int radius, Point center, Point velocity) //does not make sense to create a public constructor as the class can not be instanciated
        {
            this.radius = radius;
            this.velocity = velocity;
            this.center = center;
        }

        public abstract void Draw(Graphics g);

        public virtual void Move(int Max_X, int Max_Y) //childs can or cannot override the virtual method
        {
            //Detection of Collision
            if ((this.center.X + radius >= Max_X) || (this.center.X - radius <= 0))
            {
            }
            if ((this.center.Y + radius >= Max_Y) || (this.center.Y - radius <= 0))
            {
            }

            //Prediction of Collision
            if (this.center.X + radius + this.velocity.X >= Max_X)
            {
            }
            else if (this.center.X + this.velocity.X - radius <= 0)
            {
            }
            if (this.center.Y + this.velocity.Y + radius >= Max_Y)
            {
            }
            else if (this.center.Y + this.velocity.Y - radius <= 0)
            {
            }
        }



    }
}
