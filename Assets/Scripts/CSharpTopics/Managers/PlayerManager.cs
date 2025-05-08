using System;
using Assets.Scripts.Inheritance;

// using Assets.Scripts.Entities;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Player player1, player2;

    void Start()
    {
        // player1 = new Player("Knight", 100);
        // player2 = new Player("Bishop", 80);

        // ApplyPotion();
        // player1.PrintStats();
        // player2.PrintStats();

        // Creating new players from not the Entities.Player instead we will use Inheritance.Player
        // Entities.Player vs Inheritance.Player:
        // These two classes are named same, however their namespace are differnet, so that we can distinguish them between.
        // If we would not use the namespaces for these classes, then the compiler would definitely confused and gave an error.
        // So, we can say that, we are dashing the error as we define and use the namespaces if there are same named classes, types, etc.
        // So: Conclusion: Always use namespaces, even if they seem redundant.
        // Using namespace is best practice.
        // So to write clear and qualified code you HAVE TO use namespaces.
        // Namespaces separates the codeblock and logic behind from each other.
        // Think it like packaging.

        // var vs explicit type:
        // if you are using var keyword, then it HAVE TO initialized inline and instantly on the same line.
        // var actually defers the variable's type from the second operand. It uses the second operand to determine the type
        // So if you use var keyword then you do not have to write the type of the variable explicitly.
        string[] stringList1 = new string[] { "string1", "string2" };
        var stringList2 = new string[] { "string1", "string2" };

        player1 = new Player("Emircan", 100, stringList1);
        player2 = new Player("Bishop", 80, stringList2);
    }

    void Hacking()
    {

        // player1.health = int.MaxValue;


    }

    void ApplyPotion()
    {

        player2.Health = 990;
        Debug.Log(player2.Health);

    }
}