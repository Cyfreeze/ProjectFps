using System;

namespace Assets.Scripts.Polymorphism
{
    // Animal is a parent class of the child animals like: Cat, Dog, Lion, Dolphin, etc.
    // 
    // Correct examples:
    // Lion is an Animal
    // Mouse is an Animal
    // Dog is an Animal
    // Dolphin is an Animal
    //
    // BUT Animal is non of these!
    // => WRONG EXAMPLES:
    // Animal is a Lion
    // Animal is a Dog
    //
    // Conclusion: Animal is all of them not only one of them.
    // Animal is the parent class of the all animals
    // All animals created and inherits some behaviours from this class.
    public class AttackUnit
    {
        // Field
        private int health;
        private int attackPower;

        // --------------------------------------------------------------------
        // Properties
        public int Health
        {
            get; set;
        }
        private int AttackPower
        {
            get; set;
        }

        // --------------------------------------------------------------------
        // Constructor
        public AttackUnit(int health, int attackPower) => (Health, AttackPower) = (health, attackPower);

        // --------------------------------------------------------------------
        // Clash of clans example of the Polymorphism:
        //
        // Archer, Barbarian, Goblins: AttackUnit
        // SpawnAt() function is common between these all units
        // 2 Archer + 3 Barbarian + 5 Goblin 

        // Behaviours
        // This behaviour is shared and common between all troops in the clash of clans game.
        // This behavour will be used by all troops inherited from this class (AttackUnit).
        public virtual void SpawnAt((float x, float z) coordinates)
        {
            Console.WriteLine("the troop is spawned at the position:", coordinates.x, coordinates.z);
        }
    }

}

// Recall:
// Class outline:
// 1. Fields
// 2. Properties
// 3. Constructor
// 4. Behaviours

// outline of the defining a function
// [Access Modifier] [return type]
// If a return type of a function is void then the "return" keyword is not necessary.

// virtual: sanal, gerceklesmemis, gercek olmayan, henuz olmamiz, imaginery