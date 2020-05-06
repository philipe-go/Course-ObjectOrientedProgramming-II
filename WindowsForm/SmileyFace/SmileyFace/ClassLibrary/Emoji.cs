using System;
using System.Collections.Generic;
using System.Drawing;

namespace SmileyFace.ClassLibrary
{
    abstract class Emoji : Sprite
    {
        public int radius;

        public Emoji(Point center, Point velocity, Color color) : base(center, velocity, color)
        {
            this.radius = 75;
        }

        public Rectangle GetBounds()
        {
            Rectangle aRectangle = new Rectangle();
            aRectangle.X = Center.X - this.radius;
            aRectangle.Y = Center.Y - this.radius;
            aRectangle.Height = 2 * this.radius;
            aRectangle.Width = 2 * this.radius;

            return aRectangle;
        }

        //Move method acting 
        public override void Move(int MaxX, int MaxY)
        {
            if (Center.X + this.radius > MaxX - 10)
            {
                Velocity.X = -Velocity.X;
            }
            else if (Center.Y + this.radius > MaxY - 10)
            {
                Velocity.Y = -Velocity.Y;
            }
            else if (Center.X - this.radius < 10)
            {
                Velocity.X = -Velocity.X;
            }
            else if (Center.Y - this.radius < 10)
            {
                Velocity.Y = -Velocity.Y;
            }
        }

        public override void Draw(Graphics g)
        {
            Rectangle bounds = GetBounds();
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawEllipse(myPen, bounds);

            SolidBrush myBrush = new SolidBrush(base.BackColor);
            g.FillEllipse(myBrush, bounds);

            SolidBrush eyeBrush = new SolidBrush(Color.Black);
            g.FillEllipse(eyeBrush, new Rectangle(base.Center.X + 20, base.Center.Y - 45, 20, 40));
            g.FillEllipse(eyeBrush, new Rectangle(base.Center.X - 40, base.Center.Y - 45, 20, 40));

            myPen.Dispose();
            myBrush.Dispose();
            eyeBrush.Dispose();
        }
    }
}
