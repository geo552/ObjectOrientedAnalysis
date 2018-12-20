using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters
{
   

    class Program
    {

        static void Choose()
        {
            Console.WriteLine("Выберите персонажа");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1: 
                case 2:
                case 3:
                case 4:
            }
            Console.WriteLine("Выберите оружие");
            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1: IWeaponBehavior w = new AxeBehavior();
                    troll.SetWeapon(w); break;
                case 2: w = new BowAndArrowBehavior();
                    troll.SetWeapon(w); break;
                case 3: w = new KnifeBehavior();
                    troll.SetWeapon(w); break;
                case 4: w = new SwordBehavior();
                    troll.SetWeapon(w); break;

            }

        }

        static void Main(string[] args)
        {
            Troll troll = new Troll();

            Console.WriteLine("Выберите оружие");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:  IWeaponBehavior w = new AxeBehavior();
                    troll.SetWeapon(w);break;
                case 2:  w = new BowAndArrowBehavior();
                    troll.SetWeapon(w);break;
                case 3: w = new KnifeBehavior();
                    troll.SetWeapon(w);break;
                case 4: w = new SwordBehavior();
                    troll.SetWeapon(w);break;

            }
            troll.Fight();
        }
    }
}
