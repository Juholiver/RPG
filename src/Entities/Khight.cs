namespace DotNetRpg.src.Entities
{
    public class Khight : Hero
    {
        public Khight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP; 
        }

        public override string  Attack()
        {
            return this.Name + " Lançou um ataque fisico com sua espada ";
        }
        

    }
}