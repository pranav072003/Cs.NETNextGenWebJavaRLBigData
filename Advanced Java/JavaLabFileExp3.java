// Program demonstrating generic programming
class GenericDemo<T extends Number>
{
  T vals[];
  boolean sAvg;

  GenericDemo(T[] vals)
  {
    this.vals = vals;
  }

  public void display()
  {
    System.out.println("Values inside array of items are:");
    for(int i = 0; i < vals.length; i++)
    {
      System.out.print(vals[i] + " ");
    }
    System.out.println();
  }

  public boolean sameAvg(GenericDemo<? extends Number> obj)
  {
    double sum1 = 0.0, sum2 = 0.0;
    for(int i = 0; i < vals.length; i++)
    {
      sum1 += vals[i].doubleValue();
    }
    for(int i = 0; i < obj.vals.length; i++)
    {
      sum2 += obj.vals[i].doubleValue();
    }
    if(sum1 / vals.length == sum2 / obj.vals.length)
    {
      sAvg = true;
    }
    else
    {
      sAvg = false;
    }
    return sAvg;
  }
}

class JavaLabFileExp3
{
  public static void main(String[] args)
  {
    Integer[] intArr = {1,2,3,4,5};
    GenericDemo<Integer> intObj = new GenericDemo<Integer>(intArr);
    intObj.display();

    Double[] doubleArr = {1.1,2.2,3.3,4.4,5.5};
    GenericDemo<Double> doubleObj = new GenericDemo<Double>(doubleArr);
    doubleObj.display();

    if(intObj.sameAvg(doubleObj) || doubleObj.sameAvg(intObj))
    {
      System.out.println("Averages are same");
    }
    else
    {
      System.out.println("Averages are not same");
    }
  }
}