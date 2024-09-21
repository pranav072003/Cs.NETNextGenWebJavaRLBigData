import java.lang.*;
import java.util.*;

class Figure
{
  private String shape;
  protected float a,b;

  Figure()
  {
    shape = "undefined";
    // intialising member variable with some random value
    a = -1;
    b = -1;
  }
  
  Figure(String s, float num1, float num2)
  {
    shape = "undefined";
    // intialising member variable with some random value
    a = -1;
    b = -1;
  }
  
  double area() throws ClassNotFoundException
  {
    throw new ClassNotFoundException("Error:- Area of an " + shape + " figure is not defined.");
  }
}

class Rectangle extends Figure
{
  Rectangle(float length, float width)
  {
      // initialising the dimesions of a rectangle
      a = length;
      b = width;
      System.out.println("Rectangle with length " + length + " and width " + width + " created.");
  }

  double area() 
  {
    return a*b;
  }
}

class Triangle extends Figure
{
  Triangle(float base, float height)
  {
    // initialising the dimensions of a triangle
    a = base;
    b = height;
    System.out.println("Triangle with base " + base + " and height " + height + " created.");
  }

  double area() 
  {
    return 0.5*a*b;
  }
}

class AdvancedJavaLabPrac1
{
  public static void main(String[] args)
  {
    try
    {
        if(args.length != 2)
        {
          throw new Exception("Error:- Invalid number of arguments.");
        }
        Figure f = new Figure();
        // trying to call area of figure class, throws exception
        try
        {
          System.out.println("Area of figure is " + f.area());
        }
        catch(Exception e)
        {
          System.out.println(e.getMessage());
        }
        finally
        {
          try
          {
            f = new Rectangle(Float.parseFloat(args[0]), Float.parseFloat(args[1]));
            // trying to call area of rectangle class
            System.out.println("Area of a rectangle is " + f.area() + " sq. units.");

            f = new Triangle(Float.parseFloat(args[0]), Float.parseFloat(args[1]));
            // trying to call area of triangle class
            System.out.println("Area of a triangle is " + f.area() + " sq. units.");
          }
          catch(Exception e)
          {
            System.out.println(e.getMessage());
          }
        }
    }
    catch(Exception e)
    {
      System.out.println(e.getMessage());
    }
  }
}