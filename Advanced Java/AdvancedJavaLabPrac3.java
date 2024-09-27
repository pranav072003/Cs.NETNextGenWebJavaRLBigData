// Practical 3: Use inheritance to access super class members from base class

class SuperClassInheritDemo
{
  private int mem1;
  protected float mem2;
  public double mem3;
  String mem4;

  SuperClassInheritDemo(int mem1, float mem2, double mem3, String mem4)
  {
    this.mem1 = mem1;
    this.mem2 = mem2;
    this.mem3 = mem3;
    this.mem4 = mem4;
  }	

  public int getMem1()
  {
    return this.mem1;		
  }

  public void setMem1(int a)
  {
    this.mem1 = a;
  }
}

class AdvancedJavaLabPrac3 extends SuperClassInheritDemo
{
  AdvancedJavaLabPrac3(int a, float b, double c, String d)
  {
    // calling base class constructor
    super(a,b,c,d);
  }

  public static void main(String[] args)
  {
    try
    {
      if(args.length != 4)
      {
        throw new Exception("Error:- Invalid number of arguments.");
      }
      int num1 = Integer.parseInt(args[0]);
      float num2 = Float.parseFloat(args[1]);
      double num3 = Double.parseDouble(args[2]);
      String num4 = args[3];
      AdvancedJavaLabPrac3 obj = new AdvancedJavaLabPrac3(num1, num2, num3, num4);
      System.out.println("Value of mem1 is " + obj.getMem1());
      System.out.println("Value of mem2 is " + obj.mem2);
      System.out.println("Value of mem3 is " + obj.mem3);
      System.out.println("Value of mem4 is " + obj.mem4);

      // demonstrate setting values of member variables
      obj.setMem1((int)num2);
      obj.mem2 = (float)num3;
      obj.mem3 = (double)num1;
      obj.mem4 = num4;
      System.out.println("Updated value of mem1 is " + obj.getMem1());
      System.out.println("Updated value of mem2 is " + obj.mem2);
      System.out.println("Updated value of mem3 is " + obj.mem3);
      System.out.println("Updated value of mem4 is " + obj.mem4);
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