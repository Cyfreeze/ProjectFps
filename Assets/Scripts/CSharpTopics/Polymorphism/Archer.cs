using System;

namespace Assets.Scripts.Polymorphism
{
    // Archer is an AttackUnit
    public class Archer : AttackUnit
    {
        public Archer(int health, int attackPower) : base(health, attackPower)
        {
        }

        public override void SpawnAt((float x, float z) coordinates)
        {
            Console.WriteLine($"Archer spawned at X={coordinates.x}, Z={coordinates.z}");
        }
    }
}