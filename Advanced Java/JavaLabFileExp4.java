// Program demonstrating use of inner class
class Outer
{
  private int x;

  Outer(int x)
  {
    this.x = x;
  }

  class Inner
  {
    private int x;

    Inner(int x)
    {
      this.x = x;
    }
    
    public void display_inner()
    {
      System.out.println("Inner class: x = " + x);
    }
  }

  public void display_vars_inner_and_outer(int p)
  {
    new Inner(p).display_inner();
    System.out.println("Outer class: x = " + x);
  }
}

class JavaLabFileExp4
{
  public static void main(String[] args)
  {
    try
    {
      Outer o = new Outer(Integer.parseInt(args[0]));
      o.display_vars_inner_and_outer(Integer.parseInt(args[1]));
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