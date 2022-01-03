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
    return array;
  }  
  private static void Main()
  {
    Random random = new Random();
    Console.Write("Input number of simbol your array: ");
    uint number = uint.Parse(Console.ReadLine());
    int[] myArray = new int[number];

    for (int i = 0; i < number; i++)
    {
        myArray[i] = random.Next(-10,10);
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
            }
            /*
            
            */
        }
    }
    Console.WriteLine();
    outOfArray(myArray);
  }
}
