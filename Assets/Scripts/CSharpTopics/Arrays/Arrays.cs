using System;

public class Arrays
{
    // Arrays are basic lists that stores the same type of elements.
    // Arrays' size can not be changed in the runtime.
    // Arrays are stored sequentially in the memory (ram).
    // We define the size of the arrays before using them.

    // This array below is an integer list.
    // In the second operand there is written the size of the array which is 5.
    // As you can see, we define the size of an array beforehand
    // That means that array can store 5 integers at most, after 5 integers we should append it but it is not allowed.
    // So if we need to store more than 5 integers, we gracefully create a new array with size of 6 or more
    //  and copy the existing ones from the older one.
    private readonly int[] numberArray = new int[5];

    private void NumberArrayOperations()
    {
        // Arrays start indexing from 0.
        // For example this array we defined above, will start from 0 and goes to 4.
        numberArray[0] = 10; // First index & the element of the array indexed with: 0
        numberArray[1] = 20;
        numberArray[2] = 30;
        numberArray[3] = 40;
        numberArray[4] = 50; // Last index of the array, indexed with 4
                             // Conclusion: If we have an array that has a length of 5 then its last index is 4.
                             // => lastIndex = array.length - 1;

        // If we try to access 6. element with index 5 then it will give an error.
        Console.WriteLine(numberArray[2]); // Output: 30

        numberArray[2] = 555;

        Console.WriteLine(numberArray[2]); // Output: 555
    }


    // string[] fruits = new string[6];
    private readonly string[] fruits = { "Apple", "Banana", "Cherry" };

    private void FruitsOperations()
    {

        Console.WriteLine(fruits.Length); // Output: 3
        Console.WriteLine(fruits[0]); // Output: "Apple"
        Console.WriteLine(fruits[2]); // Output: "Cherry"
        Console.WriteLine(fruits[3]); // Output: Error: OutOfIndexError
        Console.WriteLine(fruits[1]); // Output: "Banana"
    }


    private readonly int[] ages = { 18, 25, 39, 49 };
    // Indexes of ages: 0, 1, 2, 3
    // length of the ages array: 4
    // Conclusion: the lastIndex of an array is length of the array - 1
    // => 4 - 1 : 3 => lastIndex is 3

    private void AgesArrayOperations()
    {
        Console.WriteLine(ages.Length); // Output: 4
        Console.WriteLine(ages[3]); // Output: 49
        Console.WriteLine(ages[4]); // Output: OutOfIndexError

        // Last element of the ages array is: 49
        // LastIndex of the ages array is: 3

        // i character is preffered for the loops as it is representing the "INDEX" word.
        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine("Age:" + ages[i]);
        } // Loop's output: 18, 25, 39, 49
    }

    private readonly double[] tempratures = { 98.6, 23.6, 44.5 }; // tempratures.length: 3; tempratures[2]: 44.5

    // there is a one loop that specifically designed for the enumarables.
    // this loop is read-only: that means you can not write any element of it in any iteration,
    // but you can easily read/get of elements with more performance.

    private void TempratureArrayOperations()
    {
        foreach (double temp in tempratures)
        {
            Console.WriteLine("Temprature:" + temp);
        } // Output: 98.6, 23.6, 44.5

    }

    // Multidimensional array is array of arrays
    // 2 DIMENSIONAL ARRAY IS CALLED MATRIX.
    // This array is not pointing other arrays, instead it is hold side by side in every dimension as like it is a single dimension array in RAM (memory).
    private readonly int[,] matrix = {
        { 1, 2, 3 },
        { 4, 5, 6},
        { 7, 8, 9}
    }; // in the memory this aray is hold like this:  [1, 2, 3, 4, 5, 6, 7, 8, 9]

    private void MultidimensionalArrayOperations()
    {
        Console.WriteLine(matrix[1, 2]); // Output: 6
        Console.WriteLine(matrix[2, 1]); // Output: 8
        Console.WriteLine(matrix[0, 0]); // Output: 1
    }

    // Jagged array differs from the multi dimensional array with its double square paranthesis syntax.
    // Jagged array is array of arrays. Every index of the first array of a jagged array should hold an other array.
    // Jagged array's indexes are pointing other arrays.
    // actually it does not has to be 2 dimensional always.
    // To understand the concept we are just working with matrices for now.
    private readonly int[][] jagged = new int[2][];

    private void JaggedArrayOperations()
    {
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };

        Console.WriteLine(jagged[1][2]); // Output: 5
    }

}



// recall:
// for loop is created from 3 sub statements.
// between each sub statements 2 are semi colons ;;;
//
// how does for loop works:
// 1. each iteration we first check the condition of the loop in the middle statment,
// 2. then secondly we execute the iteration,
// 3. at the end of the iteration we executre the post-operation in the third sub statement.
// for (initialization; condition; post-operation)
