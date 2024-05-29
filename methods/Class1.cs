using System;
using System.Collections.Generic;

namespace CallingMethodSim
{
    public class MathMethods
    {
        // Calculate hitpoints: magic + 10; one integer parameter and return an integer
        public static int Hitpoints(int magic)
        {
            return magic + 10;
        }

        // Calculate defense: strength - 1; one integer parameter and return an integer
        public static int Defense(int defense)
        {
            int enemy_hit = 7;
            return defense - enemy_hit;
        }

        // Calculate attack (weapon + strength bonus) - (enemy_def * crit_coeff); two integers as parameters and return an integer
        public static int Attack(int weapon, int strength)
        {
            int crit_coeff = 5;
            int enemy_def = 11;
            float triangle_bonus = weapon * 0.1f; // Assume float due to multiplication with 0.1f

            return weapon + (int)triangle_bonus - (enemy_def * crit_coeff);
        }
    }
}
