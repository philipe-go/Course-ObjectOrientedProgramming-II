using System;
using System.Collections.Generic;
using System.Drawing;

namespace SmileyFace.ClassLibrary
{
    public abstract class Sprite
    {
        public Point Center;
        public Point Velocity;
        public Color BackColor;

        public Sprite(Point center, Point velocity, Color color)
        {
            this.Center = center;
            this.Velocity = velocity;
            this.BackColor = color;
        }

        public abstract void Move(int MaxX, int MaxY);
        public abstract void Draw(Graphics g);
    }
}
