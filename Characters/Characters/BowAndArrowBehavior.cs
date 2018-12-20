using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters
{
    public class BowAndArrowBehavior:IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Выстрел из лука");
        }
    }
}
