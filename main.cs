using System;
using System.Collections.Generic;
using System.Linq;

public class Program 
{

  private static int[] outOfArray(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
        if ((i % 5) == 0)
            Console.WriteLine();
        Console.Write ($"\t{array[i]}");
    }
    Console.WriteLine();
    return array;
  }  
  private static void Main()
  {
    Random random = new Random();
    Console.Write("Input number of simbol your array: ");
    uint number = uint.Parse(Console.ReadLine()), counterSuccess = 0, counterFailure = 0;
    int[] myArray = new int[number];

    for (int i = 1; i < myArray.Length; i++)
    {        
        while (myArray[i-1] == myArray[i])
        myArray[i-1] = random.Next(0,10);
    }
    outOfArray(myArray);
 
    for (int j = 0; j < myArray.Length; j++)
    {
        for (int i = 1, buffer = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < myArray[i-1])
            {
                buffer = myArray[i];
                myArray[i] = myArray[i-1];
                myArray[i-1] = buffer;
                counterSuccess++;
            }
            else counterFailure++;
        }
    }
    Console.WriteLine();
    outOfArray(myArray);
    Console.WriteLine($"Count Success: {counterSuccess}");
    Console.WriteLine($"Count Failure: {counterFailure}\n");
    Console.Write($"Input number for search: ");   
  }
}
