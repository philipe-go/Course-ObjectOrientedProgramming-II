using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Exam
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
