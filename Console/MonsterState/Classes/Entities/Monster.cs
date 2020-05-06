using MonsterState.Classes.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterState.Classes.Entities
{
    public class Monster
    {
        #region Attributes
        private static float weaknessRatio = 0.25f; //Monster switch to weak state if hitPoints is below 25% and is an attribute that belongs to the class as all monsters will have this value
        private string name;
        private readonly int maxHitPoints; //Max Hit Points to not be changed through the match
        private int hitPoints; //Current Hit Points
        private int attack;
        private int defence;
        private int regen;
        private int dodge;
        private int critical;
        private int potionDuration;
        private Monster target;
        private IState currentState;
        List<Potion> listOfPotions;
        #endregion

        public Monster(string name, int hp, int atk, int def, int reg, int dodg, int crit)
        {
            this.name = name;
            this.hitPoints = hp;
            this.maxHitPoints = hp;
            this.attack = atk;
            this.defence = def;
            this.regen = reg;
            this.dodge = dodg;
            this.critical = crit;

            this.potionDuration = 0;
            this.target = null;
            this.currentState = NormalState.GetInstance();

            this.listOfPotions = new List<Potion>() { new Potion(2, 2) };
        }

        public Monster Monster1
        {
            get => default;
            set
            {
            }
        }

        public bool IsDead()
        {
            return this.hitPoints <= 0; //this way the method will return the result of the statement "true" or "false"
        }

        public void Recover()
        {
            if (!IsDead())
            {
                this.hitPoints += this.currentState.CalculateRegen(this.regen);
                if (this.hitPoints > maxHitPoints)
                {
                    this.hitPoints = maxHitPoints;
                }

                if ((!this.IsWeak()) && (this.currentState is WeakState))
                {
                    this.currentState = NormalState.GetInstance();
                }
            }
        }

        public void TakeDamage(int damage)
        {
            int defence = this.currentState.CalculateDefence(this.defence);
            if (damage - defence > 0)
            {
                this.hitPoints -= (damage - defence);
                if ((this.IsWeak()) && (this.currentState is NormalState))
                {
                    this.currentState = WeakState.GetInstance();
                    Console.WriteLine("The monster is now weak");
                }
            }
        }

        public void Attack()
        {
            if ((this.target != null) && (!this.target.IsDead()))
            {
                Dice dice = Dice.GetInstance();
                int criticalChance = dice.Next(0, 100);
                if (criticalChance <= this.critical)
                {
                    this.GetPotion();
                }
                int dodgeChance = dice.Next(0, 100);
                if (dodgeChance > this.target.dodge)
                {
                    int damage = this.currentState.CalculateDamage(this.attack);
                    this.target.TakeDamage(damage);
                }
                else
                {
                    Console.WriteLine("Target dodged the attack");
                }

                if(this.potionDuration > 0)
                {
                    this.potionDuration--;
                    if (this.potionDuration == 0)
                    {
                        this.currentState = (IsWeak())? (IState)WeakState.GetInstance() : (IState)NormalState.GetInstance();
                    }
                }
            }
        }

        public bool IsWeak()
        {
            return this.hitPoints <= this.maxHitPoints * Monster.weaknessRatio;
        }

        public void GetPotion()
        {
            if (this.listOfPotions.Count() > 0)
            {
                Potion obj = this.listOfPotions[0];
                this.potionDuration += obj.Rounds;
                obj.Quantity--;
                if (obj.Quantity == 0) { this.listOfPotions.RemoveAt(0); }
                
                this.currentState = SuperState.GetInstance();
            }
        }
    }
}
