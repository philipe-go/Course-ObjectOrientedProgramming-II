using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Classes.Entities;

namespace PacmanGame.Classes.States
{
    class NormalState : IState
    {
        public bool canEat(LivingEntity hungryEntity, AbstractEntity targetEntity)
        {
            if (hungryEntity is Pacman)
            {
                return (!(targetEntity is Wall) && !(targetEntity is Ghost));
            }
            if (hungryEntity is Ghost)
            {
                //return (!(targetEntity is Wall) && !(targetEntity is Pacman));
            }
            return false;
        }

        public bool canPassThrough(AbstractEntity entity)
        {
            return !(entity is Wall);
        }
    }
}
