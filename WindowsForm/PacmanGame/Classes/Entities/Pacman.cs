using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    class Pacman : LivingEntity
    {
        protected Pacman (int row, int column) : base (0, row, column)
        {
        }

        public override void Draw(Graphics g)
        {
        }
    }
}
