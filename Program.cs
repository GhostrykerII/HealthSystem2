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
        }


        static void ShowHUD()
        {
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
                Console.WriteLine("No negative numbers!");
                Health += damage;
            }

            Shield -= damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;
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


        static void ErrorChecks()
        {
            if (Shield > ShieldCap)
                Console.WriteLine("No negative numbers!");
            Shield = 100;

            if (Health > HealthCap)
                Console.WriteLine("No negative numbers!");
            Health = 100;

            Console.ReadKey(true);
        }
    }
}


