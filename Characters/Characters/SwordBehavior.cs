﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters
{
    public class SwordBehavior:IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Удар мечом");
        }
    }
}
