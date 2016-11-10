// this will demonstrate generics

using System;

namespace gennygen
{

public class GenericList<T>
{
    public void Add(T input) { }
}

class GenericRun
{
    public static void Main()
    {
        Console.WriteLine("I will create a generic, ");
        
        GenericList<int> list1 = new GenericList<int>();

        GenericList<string> list2 = new GenericList<string>();

        list1.Add(7);
        Console.WriteLine(list1);
    }
}
}




// Generics are a way to allow for a class to use different types with the same methods from the generic class
