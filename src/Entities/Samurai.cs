namespace DotNetRpg.src.Entities
{
    public class Samurai : Hero
    {
         public Samurai(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP; 
        }

        public  string  Attack(int Bonus)
        {
            if (Bonus > 4) 
            {
                return this.Name + " Lançou ataque um ataque critico com a sua destreza de: " + Bonus;
            }
            else
            {
                return this.Name + " Lançou um ataque normal com sua katana de: " + Bonus;
            }
            
            
        }
    }
}