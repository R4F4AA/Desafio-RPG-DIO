namespace POO.SRC.ENTITIS
{
    public class Kinigth : Hero
    {
       public Kinigth(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType,HP)
        {   this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        } 
    }
}