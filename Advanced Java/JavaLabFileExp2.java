// Program to find volume of cuboid and cube using abstract class
abstract class Figure
{
  protected int length, breadth, height;
  protected int side;

  abstract void volume();
}

class Cuboid extends Figure
{
  Cuboid(int l, int b, int h)
  {
    // initialising length, breadth and height of cuboid
    length = l;
    breadth = b;
    height = h;
    side = -1;  // making side invalid as cuboid is not a cube
  }

  public void volume()
  {
    // calculating volume of cuboid
    int vol = length * breadth * height;
    System.out.println("Volume of cuboid is " + vol + " cubic units");
  }
}

class Cube extends Figure
{
  Cube(int s)
  {
    // initialising side of cube
    side = s;
    // making length, breadth and height invalid as Cube is not a Cuboid
    length = breadth = height = -1;
  }

  public void volume()
  {
    // calculating volume of cube
    int vol = side * side * side;
    System.out.println("Volume of cube is " + vol + " cubic units");
  }
}

class JavaLabFileExp2
{
  public static void main(String[] args)
  {
    try
    {
      if(args.length != 4)
      {
        throw new Exception("Error:- Invalid number of arguments.");
      }
      int l = Integer.parseInt(args[0]);
      int b = Integer.parseInt(args[1]);
      int h = Integer.parseInt(args[2]);
      Cuboid c = new Cuboid(l, b, h);
      c.volume();
      int s = Integer.parseInt(args[3]);
      Cube cu = new Cube(s);
      cu.volume();
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