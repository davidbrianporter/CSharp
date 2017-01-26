using System;

namespace nspc 
{
    
    class hot 
    {
    public static void Main()
	{
        try 
        {
           int t = 1/0;
        } catch {
            Console.WriteLine("exception found");
        } finally {
            Console.WriteLine("finally, it worked?");            
        }
	}
    }
}

