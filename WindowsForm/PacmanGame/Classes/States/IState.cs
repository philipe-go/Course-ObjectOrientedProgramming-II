using PacmanGame.Classes.Entities;
using System;
using System.Collections.Generic;

namespace PacmanGame.Classes.States
{
    public interface IState
    {
        bool canPassThrough(AbstractEntity entity);
        bool canEat(LivingEntity hungryEntity, AbstractEntity targetEntity);
    }
}
