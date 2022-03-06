namespace POO.SRC.ENTITIS
{
    public class Mage : Hero
    {
        public Mage(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType, HP)
        {   this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }
        public override string Attack() => this.Name + " " + "Lançou Magia";
    }
}