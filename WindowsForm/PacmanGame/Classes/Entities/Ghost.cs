﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    class Ghost : LivingEntity
    {
        protected Ghost (int row, int column) : base (200, row, column){}

        public override void Draw(Graphics graphics)
        {

        }
    }
}
