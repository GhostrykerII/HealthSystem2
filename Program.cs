using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static int Health;
        static int Shield;
        static int Lives;
        static int HealthCap;
        static int ShieldCap;

        static void Main(string[] args)
        {
            Health = 100;
            Shield = 100;
            Lives = 3;
            HealthCap = 100;
            ShieldCap = 100;

            ShowHUD();
            Console.WriteLine("Test damage");
            TakeDamage(60);
            ShowHUD();

            Console.WriteLine("Test negative input");
            TakeDamage(-50);
            ShowHUD();

            Console.WriteLine("Heal test");
            ShieldRestore(10);
            ShowHUD();

            Console.WriteLine("Over heal test");
            ShieldRestore(150);
            ShowHUD();

            //Console.WriteLine("Death test");
            //TakeDamage(1000);
            //ShowHUD();



        }


        static void ShowHUD()
        {
           // string status;
           // status = "";

            //if ((Health >= 50) && (Health <= 75)) //&& and oporator
           // {
           //     status = "ok";
           // }

           // if ((Health >= 0) && (Health <= 25))
           // {
            //    status = "Critical";
           // }

           // if ((Health >= 25) && (Health <= 50))
           // {
            //    status = "Hurt";
           // }

           // if ((Health >= 75) && (Health <= 100))
           // {
            //    status = "Healthy";
           // }

            Console.WriteLine("Cool Game");
            Console.WriteLine(" | " + "Health:" + Health + " | " + "Shield:" + Shield + " | " + "Lives:" + Lives + " | ");
            Console.ReadKey(true);
        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player is about to take " + damage + " damage");
            Console.ReadKey(true);

            if (damage < 0)
            {
                Console.WriteLine("No negative numbers");
                return;
            }

            Shield -= damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;

            if (Shield > ShieldCap)
            {
                Console.WriteLine("No negative numbers");
                Shield = 100;

            }

            if (Health > HealthCap)
            {
                Console.WriteLine("No negative numbers");
                Health = 100;
            }
        }


        static void Heal(int HealAmount)
        {
            Console.WriteLine("You are about to heal " + HealAmount + " health");
            Health += HealAmount;
            if (Health > HealthCap)
                Health = HealthCap;
        }

        static void ShieldRestore(int HealAmount)
        {
            Console.WriteLine("Shield Restore");
            Shield += HealAmount;
            if (Shield > ShieldCap)
                Shield = ShieldCap;

        }

        static void YouDied()
        {
            if (Lives == 0)
            {
                Console.WriteLine(" You died! ");
                Console.WriteLine("-----------");
                Console.WriteLine("  Restart  ");
                Console.ReadKey(true);
                Reset();
            }
        }

        static void Reset()
        {
            Health = 100;
            Lives = 3;
            Shield = 100;
        }
    }
}


