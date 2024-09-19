using System;

public class HelloWorld
{
    static int factorial(int a)
    {
        if(a==1)
        {
            return 1;
        }
        return a*factorial(a-1);
    }
    
    public static void Main(string[] args)
    {
        while(true)
        {
            try
            {
                Console.WriteLine("Enter a non negative number");
                int a = Int32.Parse(Console.ReadLine());
                if(a<0)
                {
                    // throw exception
                    throw new FormatException();
                }
                Console.WriteLine("Factorial of inputted number " + a + " is " + factorial(a));
                break;
                
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid number inputted!");
                continue;
            }
            finally
            {
                Console.WriteLine("Program ended!");
            }
        }
    }
}