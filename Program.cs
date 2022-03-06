using System;
using POO.SRC.ENTITIS;

namespace POO
{
    class program
    {
        static void Main(string[] agrs)
        {
            Kinigth Arus = new Kinigth("Arus" , 23 , "Knight" , 469);
            Wizard Jenica = new Wizard("Jenica",24, "White Wizard", 325);
            Mage Topapa = new Mage("Topapa",22, "Black Wizard", 106);
            Ninja Wedge = new Ninja("Wedge",21, "Ninja", 292);

                Console.WriteLine(Arus);
                Console.WriteLine(Jenica);
                Console.WriteLine(Topapa);
                Console.WriteLine(Wedge);

                //Console.WriteLine(Arus.Attack());
                //Console.WriteLine(Jenica.Attack(20));
                //Console.WriteLine(Topapa.Attack());
                //Console.WriteLine(Wedge.Attack());

            
          
        }
    }
}

