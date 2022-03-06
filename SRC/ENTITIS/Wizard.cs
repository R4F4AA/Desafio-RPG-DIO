namespace POO.SRC.ENTITIS
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType, HP)
        {   this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;

        }
        public override string Attack() => this.Name + " " + "Lançou Magia";
        public string Attack(int Bonus){
            
            if(Bonus > 12){
                return this.Name + " " + "Lançou Magia Super efetiva com bonus de  " + Bonus;
            }else{
                return this.Name + " " + "Lançou Magia com bonus de  " + Bonus;
            } 
            
        }
    }
}
