using System;
using System.Collections.Generic;

public class run
{

    public static void Main()
    {
        //should the collection go in the main method? or a new collection class

          List<int> numbers = new List<int>();

              int[] arr = new int[3]{10,9,2};
	      
	      foreach (int num in arr)
              {
        // where does the Add method come from?
                  numbers.Add(num);
		  Console.WriteLine(number);
              }

        Console.WriteLine("hi");

    }

}
