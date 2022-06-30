namespace DotNetRpg.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP )
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.HP = HP;
            this.MP = MP;
        }
        public Hero ()
        {

        }
        
        public string Name { get; set; }
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;


        public override string ToString()
        {
            return "Atribudos do Heroi: " + " Nome:" + this.Name + " Level:" + this.Level + " Classe:" + this.HeroType + " Vida(HP):" + this.HP + " Mana(MP):" + this.MP + " ";
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}