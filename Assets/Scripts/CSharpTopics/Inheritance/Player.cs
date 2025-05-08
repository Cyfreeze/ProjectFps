namespace Assets.Scripts.Inheritance
{
    // Player is Character
    // this symbol : corresponds "is" in english
    // Player actually is a child of a Character
    // Character is the parent of the child. 
    // So we can say: 
    // - Child is Player.
    // - Parent is Character
    public class Player : Character
    {
        // Class Outline
        //
        // from top to bottom outline:
        // 1. field
        // 2. properties
        // 3. constructor or special other functions
        // 4. behaviours (actions)

        // --------------------------------------------------------------------

        // Fields vs Props
        // fields are not exposed by the class itself.
        // fields are defined as private as much as we can.
        // private things written in a class can not be accessed by another class or function.
        // if a developer or any other script want to modify or read a filed then it should use the Props (Properties).
        // and thus, we define properties which grant access to the fields in conditions we determined prehand.

        // --------------------------------------------------------------------

        // Defining outline:
        // [Access modifier] [type] [variable name] ([operation] = 2. operand)(Optional)
        //
        // Examples:
        // private            int      testNumber      ;
        // public             string   testString      = "Hello, World";

        // --------------------------------------------------------------------

        // arrays: List of same type of elements
        // arrays written with [] syntax
        // arrays are basically a collection of items. We can say it is essentially a list
        //
        // Defining an array:
        // [Access modifier] [type[]] [list name] ([operation] = 2. operand)(Optional)
        // 
        // Examples:
        // private             int[]    listOfInts
        // public              string[]  listOfNames

        // --------------------------------------------------------------------

        // Methods vs Functions
        // 1. methods are owned by a class.
        // 2. all methods are functions, but not all functions are methods.
        // method => function

        // --------------------------------------------------------------------

        // annotation: dipnot
        // annotations are written just above the documented element which can be: a class, method, function, etc.

        // --------------------------------------------------------------------

        // itemsList is a field
        // itemsList is a list 
        private string[] itemsList;

        // ItemsList is a Property of the itemsList field
        // ItemsList grants out access by its get & set functionalities.
        public string[] ItemsList
        {
            // In the get method it basically returns the itemsList field
            get { return itemsList; }
            // In the set method, however it sets the value got by the 2. operand of the operation:
            //
            // [Access Modifier] [type] [variable name]
            // Example:
            // public Player player = new Player();
            // player.ItemsList = []string{"selam0", "hi1", "h2"};
            // if such a scenario exists like above our value is this: []string{"selam0", "hi1", "h2"}
            set { itemsList = value; }

        }

        // Strings are covered by double quotation marks 
        // Example:
        // "Emircan"
        // "Berkay"

        // Constructor of the class
        // Constructor is a special function(method) which is named as the same name with the class itself.
        // Constructor is called and executed whenever a new instance of the class generated.
        //
        // If there is a new keyword, then we can say that there is called a constuctor of some class.
        // Example generation:
        // Player emircanPlayer = new Player("Emircan", 100, string[]{"string1", "string2"})
        public Player(string name, int health, string[] itemsList) : base(name, health)
        {
            this.itemsList = itemsList;
            this.Health = 100;

            TakeDamage(20);
        }
    }

}