using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalExam.State;

namespace FinalExam.Entities
{
    public class Enemy : Fighter
    {

        public Image image = Image.FromFile("../../Resources/monster.png");


        public Enemy(int hp, int row, int colum) : base(hp, row, colum)
        {
        }

        public override void Draw(Graphics g)
        {
            int size = Maze.cellSize;
            Rectangle bounds = new Rectangle(this.column * size, this.row * size, size, size);
            g.DrawImage(image, bounds);
        }

        //Question 1.2
        public void Attack(Mario mario)
        {
            while (this.hit_points > 0)
            {
                this.hit_points -= mario.damage;

                if (this.Is_Dead())
                {
                    mario.State = Normal_State.GetInstance();
                    mario.Gain_Experience();
                    this.Die();
                }

                mario.hit_points -= this.damage;

                if (mario.Is_Dead())
                {
                    mario.Loose_Life();
                }
            }
        }

        public void Die()
        {
            Maze.Remove_Entity(this.row, this.column);
        }
    }

}
