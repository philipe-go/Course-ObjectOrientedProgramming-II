using PacmanGame.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    public abstract class AbstractEntity
    {
        #region Attributes
        private int row;
        private int column;
        private Point location;
        private int score;
        bool eaten;
        Color color;
        #endregion

        #region Properties
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public Point Location { get => location; set => location = value; }
        public int Score { get => score; set => score = value; }
        public bool Eaten { get => eaten; set => eaten = value; }
        public Color Color { get => color; set => color = value; }
        #endregion

        protected AbstractEntity(int row, int column, int score)
        {
            this.row = row;
            this.column = column;
            this.score = score;
            this.eaten = false;
            this.color = Color.White;
            int x = this.column * Map.cellSize;
            int y = this.row * Map.cellSize;
            this.location = new Point(x, y);
        }
        
        public abstract void Draw(Graphics graphics);
    }
}
