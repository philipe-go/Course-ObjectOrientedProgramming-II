using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    public abstract class LivingEntity : AbstractEntity
    {
        Direction currentDirection;

        protected LivingEntity(int score, int row, int column) : base(score, row, column) 
        {
            currentDirection = Direction.NONE;
        }


        public abstract void Draw();
    }
}
