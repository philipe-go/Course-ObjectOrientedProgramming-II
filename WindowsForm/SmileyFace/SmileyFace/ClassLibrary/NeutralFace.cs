using System;
using System.Collections.Generic;
using System.Drawing;

namespace SmileyFace.ClassLibrary
{
    class NeutralFace : Emoji
    {
        public NeutralFace(Point center, Point velocity) : base(center, velocity, Color.Orange) { }

        //draw method acting alongside base.Draw
        public override void Draw(Graphics g)
        {
            base.Draw(g);

            Point startPoint = new Point(Center.X - 30, Center.Y + 25);
            Point endPoint = new Point(Center.X + 25, Center.Y + 25);
            Rectangle aRectangle = new Rectangle(Center.X - 30, Center.Y + 5, 60, 50);
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawLine(myPen, startPoint, endPoint);

            myPen.Dispose();
            g.Dispose();
        }
    }
}
