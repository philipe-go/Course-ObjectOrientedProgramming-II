using System;

namespace Pokemon
{
    public abstract class Monster
    {
        #region Attributes
        private int defence;
        private int hitpoint;
        private int damage;
        private int regen;
        private int dodge;
        private int criticalChance;
        private Monster target;
        #endregion

        #region Properties
        public int Defence { get => defence; set => defence = value; }
        public int Hitpoint { get => hitpoint; set => hitpoint = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Regen
        {
            get => regen;
            set => regen = (value > Hitpoint)? Hitpoint : value;
        }
        public int Dodge
        {
            get => dodge;
            set => dodge = (value < 0)? 0 : (value > 50)? 50 : value; //IF STATEMENT IN JUST ONE LINE BUT CAN BE USED IN THE REGULAR MODE
        }
        public int CriticalChance
        {
            get => criticalChance;
            set => criticalChance = (value < 0)? 0: value; //BUSINESS RULES
        }
        public Monster Target { get => target; set => target = value; }
        #endregion

        protected Monster(int hit_points, int damage, int defence, int dodge, int critical_chance)
        {
            this.Hitpoint = hit_points;
            this.Damage = damage;
            this.Defence = defence;
            this.Dodge = dodge;
            this.CriticalChance = critical_chance;
            this.target = null;
        }

        public virtual void Atack()
        {
            Dice dice = Dice.GetInstance(); //to recover the singleton object

            if ((this.Target != null) && (!this.Target.IsDead())) //remember to check the order so the runtime does not check a method of a null object 
            {
                int calculateDamage = CalculateDamage();
                int result = dice.Next(0,100);

                if (result > this.Target.Dodge)
                {
                    calculateDamage -= this.Target.defence;
                    this.Target.Hitpoint -= calculateDamage;
                }
            }

            Console.WriteLine("End Atack");

            //if ((base.Target != null) & (!base.Target.IsDead())) //only one & checks the second condition as well and in this case thrown an exception error 
            //{
            //    int result = dice.RollDice();
            //}
        }

        public virtual void Recover()
        {
            this.Hitpoint += this.regen;
        }

        public abstract int CalculateDamage(); //method that the childrens will override to have their own behaviour of this method
        
        public bool IsDead()
        {
            return (this.Hitpoint <= 0); //will just return the condition true considering this statement
        }
    }
}
