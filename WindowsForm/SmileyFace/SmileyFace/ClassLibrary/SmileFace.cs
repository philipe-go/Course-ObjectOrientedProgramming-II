using System;
using System.Collections.Generic;
using System.Drawing;

namespace SmileyFace.ClassLibrary
{
    class SmileFace : Emoji
    {
        public SmileFace(Point center, Point velocity) : base(center, velocity, Color.Yellow) {  }
        
        //draw method acting alongside base.Draw
        public override void Draw(Graphics g)
        {
            base.Draw(g);

            Rectangle aRectangle = new Rectangle(Center.X - 30, Center.Y + 5, 60, 50);
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawArc(myPen, aRectangle, 0.0f, 180.0f);

            myPen.Dispose();
            g.Dispose();
        }
    }
}
