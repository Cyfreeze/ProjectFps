using System;
using UnityEditor;
using UnityEngine.Animations;

public class Character
{

    private string name;

    private int health;

    public string Name
    {
        get { return name; }


    }
    public int Health
    {
        get { return health; }
        set { health = Math.Clamp(value, 0, 100); }


    }

    public Character(string name, int health)
    {

        this.name = name;
        this.health = health;


    }
    public void TakeDamage(int dmg)
    {

        Character ch = new Character("Joe", 90);


        ch.Health -= dmg;

    }

}
