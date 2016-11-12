using System;
using System.Collections.Generic;

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

public class run
{

    public static void Main()
    {
        List<int> numbers = new List<int>();
        int[] arr = new int[3]{10,9,2};
	      
	foreach (int num in arr)
        {
            numbers.Add(num);
	}

        foreach (int n in numbers)
	{
            Console.WriteLine(n);
	}

string s = "Hello";

foreach (char c in s)
{
    Console.Write(c + ".");
}

    }
}
