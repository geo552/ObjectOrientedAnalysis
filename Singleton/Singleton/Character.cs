using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Character
    {
        private static Character uniqueInstance;
        private static int health;
        private string name;
        private static bool status;
        private static bool shield;
        private Character() : this("Неизвестно") { }

        private Character(string name) : this(name, health = 100) { }

        private Character(string name, int health)
        {
            this.name = name;
            
        }
        

        public static Character getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Character();
            }
            return uniqueInstance;
        }

        /*public int Healing()
        {
            if (status == false)
            {
                health = health + (100 - health);
                return health;
            }

            else return 0;

        }*/

        /*public int GetDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(20, 50);
            health = health - damage;

            if (health > 0)
            {
                return health;
            }

            else
            {
                status = true;
                health = 0;
                return health;
            }
        }*/

        public int GetHeadDamage()
        {

            
            int damage = 0;
            if (health > 0)
            {
                if (shield == ShieldUp() && health > 0)
                {
                    damage = 0;
                    health = health - damage;
                    ShieldDown();
                    return health;
                }
                else
                {
                    damage = 40;
                    health = health - damage; 
                }
            }
            if (health > 0)
                return health;
            else
            {
                status = true;
                health = 0;
                return health;
            }

        }

        public int GetBodyDamage()
        {
            int damage = 0;
            if (health > 0)
            {
                if (shield == ShieldUp() && health > 0)
                {
                    damage = 0;
                    health = health - damage;
                    ShieldDown();
                    return health;
                }
                else
                {
                    damage = 30;
                    health = health - damage;    
                }
            }
            if (health > 0)
                return health;
            else
            {
                status = true;
                health = 0;
                return health;
            }
        }

        public int GetLegDamage()
        {
            int damage = 0;
            if (health > 0)
            {
                if (shield == ShieldUp() && health > 0)
                {
                    damage = 0;
                    health = health - damage;
                    ShieldDown();
                    return health;
                }
                else
                {
                    damage = 20;
                    health = health - damage;
                }
            }
            if (health > 0)
                return health;
            else
            {
                status = true;
                health = 0;
                return health;
            }
        }

        public bool IsDead()
        {
            if (status == true)
            {
                //Console.WriteLine("Персонаж мёртв, воскресите его, чтобы продолжить ");
                status = true;
                return status;

            }
            else
            {
                status = false;
                return status;
            }
        }
        public bool ShieldUp()
        {
            shield = true;
            return shield;
        }

        public bool ShieldDown()
        {
            shield = false;
            return shield;
        }
    /*    public bool Revive()
        {
            status = false;
            return status; 
        }*/



        




        


    
    }
}
