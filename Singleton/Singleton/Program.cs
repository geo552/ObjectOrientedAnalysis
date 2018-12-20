using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
           Character character = Character.getInstance();
           Character2 rival = Character2.getInstance();
           Random rand = new Random();
           do
           {
               int dice = rand.Next(1,7);
               int armor = rand.Next(1, 3);
               if (dice == 1 )
               {
                   Console.WriteLine("\nHPC = {0}", character.GetHeadDamage());
                   character.IsDead();
               }
               if (dice == 2)
               {
                   Console.WriteLine("\nHPR = {0}", rival.GetHeadDamage());
                   rival.IsDead();
               }
               if (dice == 3)
               {
                   Console.WriteLine("\nHPR = {0}", rival.GetBodyDamage());
                   rival.IsDead();
               }
               if (dice == 4)
               {
                   Console.WriteLine("\nHPR = {0}", character.GetBodyDamage());
                   rival.IsDead();
               }
               if (dice == 5)
               {
                   Console.WriteLine("\nHPR = {0}", character.GetLegDamage());
                   rival.IsDead();
               }
               if (dice == 6)
               {
                   Console.WriteLine("\nHPR = {0}", rival.GetLegDamage());
                   rival.IsDead();
               }

               if (armor == 1)
               {
                   character.ShieldUp();
               }

               if (armor == 2)
               {
                   rival.ShieldUp();
               }
               
             
           } while ((character.IsDead() != true) && (rival.IsDead() != true));

           if (rival.IsDead() == true)
           {
               Console.WriteLine("Character wins!");
           }
           if (character.IsDead() == true)
           {
               Console.WriteLine("Rival wins!");
           }
           /* ConsoleKeyInfo key;
            Console.WriteLine("Персонаж создан\n HP = 100");
            /*
            do
            {
               /* char c;
                c = Convert.ToChar(Console.ReadLine()); 
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.H )
                {
                    Console.WriteLine("\nHP = {0}",character.Healing());
                    Console.WriteLine("\nПерсонаж был излечён");
                }

                if (key.Key == ConsoleKey.G)
                {
                    Console.WriteLine("\nHP = {0}",character.GetDamage()); 
                    Console.WriteLine("\nПерсонаж получил урон");
                    character.IsDead();
                }

                
                if (key.Key == ConsoleKey.R)
                {
                    character.Revive();
                    Console.WriteLine("\nПерсонаж воскрес,можете его вылечить");
                }

            } while (key.Key!=ConsoleKey.Escape);*/
        }
    }
}
