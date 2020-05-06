
namespace Pokemon
{
    public class GrassMonster : Monster
    {
        public GrassMonster(int hit_points, int damage, int defence, int dodge, int critical_chance) : base(hit_points, damage, defence, dodge, critical_chance)
        {
        }

        public override int CalculateDamage()
        {
            int finaldamage = 0;
            Dice dice = Dice.GetInstance();

            if (base.Target is FireMonster)
            {
                finaldamage = base.Damage / 2;
            }
            if (base.Target is WaterMonster)
            {
                finaldamage = base.Damage * 2;
            }
            if (base.Target is GrassMonster)
            {
                int criticalHit = dice.Next(0,100);
                if (criticalHit < base.Damage)
                {
                    finaldamage = 2 * base.Damage;
                }
                else { finaldamage = base.Damage; }
            }

            return finaldamage;
        }

    }
}
