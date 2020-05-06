
namespace Pokemon
{
    public class WaterMonster : Monster
    {
        public WaterMonster(int hit_points, int damage, int defence, int dodge, int critical_chance) : base(hit_points, damage, defence, dodge, critical_chance)
        {
        }

        public override int CalculateDamage()
        {
            int finaldamage = 0;
            Dice dice = Dice.GetInstance();

            if (base.Target is FireMonster)
            {
                finaldamage = base.Damage * 2;
            }
            if (base.Target is WaterMonster)
            {
                int criticalHit = dice.Next(0,100);
                if (criticalHit < base.Damage)
                {
                    finaldamage = 2 * base.Damage;
                }
                else { finaldamage = base.Damage; }
            }
            if (base.Target is GrassMonster)
            {
                finaldamage = base.Damage / 2;
            }

            return finaldamage;
        }

    }
}
