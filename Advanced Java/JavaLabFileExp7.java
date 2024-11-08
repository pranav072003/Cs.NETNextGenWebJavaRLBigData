// Program demonstrating multithreading using Thread class or Runnable interface
class ThreadImp implements Runnable
{
  Thread t;
  int id;

  ThreadImp(String name, int id)
  {
    t = new Thread(this, name);
    this.id = id;
    System.out.println("Thread " + id + " is created by implementing runnable interface");
    t.start();
  }

  public void run()
  {
    System.out.println("Thread " + id + " is running");
    try
    {
    Thread.sleep(1000);
    }
    catch(InterruptedException e)
    {
      System.out.println("Exception has been raised as a sleeping thread is abruptly resumed/waken up.");
    }
  }
}

class ThreadExt extends Thread
{
  Thread t;
  int id;
  
  ThreadExt(String name, int id)
  {
    t = new Thread(this, name);
    this.id = id;
    System.out.println("Thread " + id + " is created by extending Thread class");
    t.start();
  }

  public void run()
  {
    System.out.println("Thread " + id + " is running");
    try
    {
    Thread.sleep(1000);
    }
    catch(InterruptedException e)
    {
      System.out.println("Exception has been raised as a sleeping thread is abruptly resumed/waken up.");
    }
  }
}

class JavaLabFileExp7
{
  public static void main(String[] args)
  {
    ThreadImp t1 = new ThreadImp("Thread 1", 1);
    ThreadImp t2 =new ThreadImp("Thread 2", 2);
    ThreadImp t3 = new ThreadImp("Thread 3", 3);
    ThreadExt t4 = new ThreadExt("Thread 4", 4);
    ThreadExt t5 = new ThreadExt("Thread 5", 5);
    ThreadExt t6 = new ThreadExt("Thread 6", 6);
    
    try
    {
      t1.t.join();
      t2.t.join();
      t3.t.join();
      t4.t.join();
      t5.t.join();
      t6.t.join();
    }
    catch(InterruptedException e)
    {
      System.out.println("Exception has been raised as a sleeping thread is abruptly resumed/waken up.");
    }
    finally
    {
      System.out.println("Program ended!");
    }
  }
}