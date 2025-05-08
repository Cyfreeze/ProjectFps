namespace Assets.Scripts.Polymorphism
{
    public class UnitManager
    {
        void Start()
        {
            AttackUnit archer1 = new AttackUnit(100, 4);
            AttackUnit archer2 = new Archer(60, 5); // archer is a handler. Think is as a phone holder.

            // Telephone telephoneHolder = new Telephone(); // SUCCESS
            // Telephone telephoneHolder = new Tablet(); // ERROR!!!

            // public class Iphone13: Telephone {}
            // public class SamsungA10: Telephone {}
            // public class Ipad8

            // Telephone telephoneHolder1 = new Iphone13(); // SUCCESS
            // Telephone telephoneHolder2 = new SamsungA10(); // SUCCESS
            // Telephone telephoneHolder3 = new Ipad8(); // ERROR!

            // archer2 is essentially an AttacUnit.
            // That is why we can pass the archer2 without any problem to a AttackUnit type parameter.
            Foo(archer2);
        }

        // Polymorphism allows us to behave a child classes as if they are its parent class.
        // This allows us to manage whole classes in a group behaviour.
        // That way Archer is become an AttackUnit so that we can apply all logics that belongs to the AttackUnit
        // Conclusion: Archer is an AttackUnit
        // AttackUnit may contain many behavours and fields, then any Archer would inherit these belongings and use them as if they own it.
        // We can pass any Archer object as if it is an AttackUnit to a parameter that waits for a AttackUnit type object.
        // To sum up: That means Archer became both Archer and AttackUnit at the same time
        // That is why we call it PolyMorphism: It's dictionary meaning is Many Interfaces or Many Skin :D
        // Think it as it can change its skin to fit in the condition.

        // This function below waits for an AttackUnit type object but we will pass an Archer and see what happens
        public void Foo(AttackUnit awaitedObject)
        {
            // Do nothing, just observe the parameter's behaviour.
            return;
        }

        // public void Foo2(Archer awaitedObject)
        // {
        //     // Do nothing, just observe the parameter's behaviour.
        //     return;
        // }
    }
}