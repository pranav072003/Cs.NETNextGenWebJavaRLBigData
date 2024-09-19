using System;

class HelloWorld
{
  public static int max(string[] arr)
  {
      int a = Int32.Parse(arr[0]);
      for(int i = 1; i < arr.Length; i++)
      {
          if(Int32.Parse(arr[i]) > a)
          {
              a = Int32.Parse(arr[i]);
          }
      }
      return a;
  }
    
  public static void Main(string[] args)
  {
    Console.WriteLine("Hello World");
    
    string msg = "Enter your name:-";
    int a = 5;
    double b = 8.12375;
    const float PI = 3.14159F;
    
    Console.WriteLine(msg);
    string reply = Console.ReadLine();
    Console.WriteLine("Hello " + reply + "!!");
    
    Console.Write("Enter two integer numbers:-");
    string s = Console.ReadLine();
    string[] arr = s.Split(' ');
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(Int32.Parse(arr[i]));
        Console.Write(" ");
    }
    Console.WriteLine();
    int m = max(arr);
    Console.WriteLine("Maximum of the inputted numbers is " + m);
    Console.WriteLine("Value of PI is " + PI);
  }
}