using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters
{
    public class User
    {
        public ICharacterBehavior character;
        public IWeaponBehavior weapon;

        public void SetCharacter(ICharacterBehavior c)
        {
            this.character = c;
        }
        public void SetWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }
    }
}
