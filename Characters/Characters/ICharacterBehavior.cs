using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Characters
{
    public interface ICharacterBehavior
    {

        public void UseCharacter();
        public void Fight();
        
        /*public void SetWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }*/
    }
}
