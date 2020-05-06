using PacmanGame.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PacmanGame.Classes.Entities
{
    class Wall : AbstractEntity
    {
        public Wall (int row, int column) : base(0, row, column) 
        {
            this.Color = Color.DarkBlue;
        }

        public override void Draw (Graphics g)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            int side = Map.cellSize;

            Rectangle bounds = new Rectangle(x, y, side, side);
            Brush myBrush = new SolidBrush(this.Color);
            g.FillRectangle(myBrush, bounds);
            
            myBrush.Dispose();
        }
    }
}
