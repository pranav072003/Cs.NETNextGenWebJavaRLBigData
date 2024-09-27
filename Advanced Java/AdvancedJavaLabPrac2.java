// Practical 2:- Demonstrate overloading by using sum() method in three different ways, multiply() in two different ways by overloading constructors

class OverLoadDemo
{
  // product results
  int product1;
  float product2;

  // overloading sum() methods

  public void sum(int a, int b)
  {
    System.out.println("Version 1 of sum() method returns result as " + (a+b));	
  }

  public void sum(int a, float b)
  {
    float c = (float)a + b;
    System.out.println("Version 2 of sum() method returns result as " + c);	
  }

  public void sum(double a, double b)
  {
    System.out.println("Version 3 of sum() method returns result as " + (float)(a+b));	
  }

  // overloading multiply() method using constructor overloading

  OverLoadDemo(int a, int b)
  {
    this.product2 = 0;
    this.product1 = a*b;
    System.out.println("Version 1 of multiply() method gives product of numbers- a= " + a + " and b= " + b + " as " + product1);
  }

  OverLoadDemo(float a, float b)
  {
    this.product1 = 0;
    this.product2 = a*b;
    System.out.println("Version 2 of multiply() method gives product of numbers- a= " + a + " and b= " + b + " as " + product2);
  }
}

class AdvancedJavaLabPrac2
{
  public static void main(String[] args)
  {
    try
    {
      if(args.length != 4)
      {
        throw new Exception("Illegal number of arguments");	
      }
      int num1 = Integer.parseInt(args[0]);
      int num2 = Integer.parseInt(args[1]);
      float num3 = Float.parseFloat(args[2]);
      float num4 = Float.parseFloat(args[3]);

      OverLoadDemo obj1 = new OverLoadDemo(num1, num2);
      OverLoadDemo obj2 = new OverLoadDemo(num3, num4);
      obj1.sum(num1, num2);
      obj1.sum(num1, num3);
      obj1.sum((double)num1, (double)num4);
    }
    catch(Exception e)
    {
      System.out.println(e.getMessage());
    }
    finally
    {
      System.out.println("Program ended");
    }
  }
}