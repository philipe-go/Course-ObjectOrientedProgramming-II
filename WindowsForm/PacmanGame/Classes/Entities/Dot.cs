using PacmanGame.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    class Dot : AbstractEntity
    {
        public Dot(int row, int column) : base (10, row, column) { }

        public override void Draw(Graphics g)
        {
            int x = this.Location.X + 2* (Map.cellSize / 5);
            int y = this.Location.Y + 2* (Map.cellSize / 5);
            int side = Map.cellSize /5;

            Rectangle bounds = new Rectangle(x, y, side, side);
            Brush myBrush = new SolidBrush(this.Color);
            g.FillEllipse(myBrush, bounds);

            myBrush.Dispose();
        }
    }
}
