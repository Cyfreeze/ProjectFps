
using System;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    GameObject player;

    void Awake()
    {
        player = this.gameObject;

        // Primitive types
        int a;
        double b = 2.7;
        char c = 'H';
        string d = "World";
        bool e = false;
        var f = 12;

        // Operators
        // Arithmetic: +, -, *, /, %
        // int result = a + (int)b;
        string result2 = c + d[0].ToString(); // "HW"


        Debug.Log(result2);
        // Comparison: ==, !=, >, <, >=, <=
        // Logical: && (AND), || (OR), ! (NOT)
        e = 1 == 2;
        e = 1 != 2;
        e = !(1 == 2);

        e = 1 == 1;
        e = 1 > 2;
        e = 1 < 2;

        e = 1 > 1;
        e = 1 >= 1;

        e = (1 == 1) && (1 == 2);
        e = (1 == 1) || (1 == 2);
        e = true || false;

        e = true | false;
        e = true & false;

        // Bitwise: & (Bitwise AND), | (Bitwise OR), ^ (Bitwise XOR), ~ (Bitwise NOT), << (LEFTSHIFT), >> (RIGHTSHIFT)

        int test;
        test = 11 & 10;
        test = 11 | 10;
        test = 3 << 4;
        // 1001 = 9
        // 0001 = 1
        // 1000 = 8
        // 0110 = 6
        // 1011 = 11
        // 0011 = 3
        // 0011 << 2 = 1100

        test = 8 >> 2;
        // 1000 >> 2 = 0010

        if (false)
        {
            Debug.Log("ekmek");

        }
        else if (true)
        {

            Debug.Log("Kola");

        }
        else if (2 == 2)
        {

            Debug.Log("Ayran");

        }
        else
        {

            Debug.Log("Kofte");

        }

        // 90 ve uzeri not alanlar A harfi alsin,
        // 80 ve 90 arasinda not alanlar B harfi alsin,
        // 80'den dusuk alanlar F harfi alsin

        const int grade = 80;

        if (grade >= 90)
        {
            Debug.Log("A");
        }
        else if (grade < 90 && grade > 80)
        {
            Debug.Log("B");
        }
        else
        {
            Debug.Log("F");
        }

        if (grade == 80)
        {
            Debug.Log("LOL");
        }


        // int i = 0;
        // while (i < 10)
        // {
        //     // i = i+1
        //     i++;
        //     Debug.Log(i);
        // }
        // Debug.Log("AAA");

        // for (int i = 0; i < 10; Debug.Log("i: " + i++))
        // {
        //     Debug.Log(i);

        // }

        int i = 0;
        do
        {
            Debug.Log("Iteration: " + i);
            i++;
        } while (i < 5);
    }

    void Start()
    {
        string message = "message2";
        bool bomessage = false;

        SayHello("message", true, 6.18f);
        SayHello(yes: bomessage, message: message);
        SayHello(new string("message3"), new bool());

        Debug.Log(ComposeMyMessage(84, "Hello", "World", "Kri"));
    }

    void Update()
    {

    }

    void LateUpdate()
    {

    }

    void FixedUpdate()
    {

    }

    void SayHello(string message, bool yes, float number = 3.14f)
    {
        Debug.Log(message);
        Debug.Log(yes);
        Debug.Log(number);

        Debug.Log(AddNumbers(9, 3.8));


    }

    float AddNumbers(int firstNumber, double secondNumber)
    {
        float result = (float)firstNumber + (float)secondNumber;


        return result;
    }
    string ComposeMyMessage(int firstParameter, params string[] otherParameters)
    {
        return firstParameter + " " + otherParameters[0] + " " + otherParameters[1];

    }

}

