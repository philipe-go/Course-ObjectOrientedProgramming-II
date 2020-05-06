using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Entities
{
    public abstract class Fighter : Entity
    {
        //Question 1.1
        internal int damage;
        internal int hit_points;
        internal int initialHP;
        private Dice dice = Dice.Get_Instance();

        public Fighter(int hp, int row, int colum) : base(row, colum)
        {
            this.initialHP = hp;
            this.hit_points = hp;
            this.damage = dice.Next(10, 16);
        } 

        public bool Is_Dead()
        {
            return this.hit_points <= 0;
        }
    }
}
