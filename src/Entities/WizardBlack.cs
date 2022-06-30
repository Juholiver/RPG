namespace DotNetRpg.src.Entities
{
    public class WizardBlack : Hero
    {
        public WizardBlack(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP; 
        }
        public override string  Attack()
        {
            return this.Name + " Lançou magia negra com seu cajado ";
        }

        public  string  Attack(int Bonus)
        {
            if (Bonus > 3) 
            {
                return this.Name + " Lançou magia negra super efetiva com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia negra com força fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}