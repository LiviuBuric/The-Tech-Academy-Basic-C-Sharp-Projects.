using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered the Dragon!");
            int enemy_damage = new Random().Next(5, 15);
            Console.WriteLine("Dragon does " + enemy_damage + " HP of damage.");
            int defense = Convert.ToInt32(Console.ReadLine());
            int life_points = 100 - enemy_damage + defense;
            Console.WriteLine("Your healer heals you by: " + defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            int hitpoints = Convert.ToInt32(Console.ReadLine());
            life_points += hitpoints;
            Console.WriteLine("Your healer heals you by: " + hitpoints);
            int magic_hitpoints = new Random().Next(0, 5);
            life_points += magic_hitpoints;
            Console.WriteLine("You have been healed for magic: " + magic_hitpoints + ".");

            if (hitpoints > 10)
            {
                int critical_hit = new Random().Next(10, 20);
                life_points += critical_hit;
                Console.WriteLine("You've landed a critical strike and dealt " +
                    critical_hit + " HP worth of damage.");
            }
            else
            {
                int damage_dealt = new Random().Next(1, 10);
                life_points -= damage_dealt;
                Console.WriteLine("You've attacked; your strength total is " + damage_dealt + ".");
            }

            Console.ReadLine();
        }
    }
}
