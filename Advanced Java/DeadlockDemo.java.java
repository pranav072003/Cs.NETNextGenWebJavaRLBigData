class A implements Runnable
{
    Thread t;
    
    A(String name)
    {
        t = new Thread(this, name);
        t.start();
    }
    
    public void run()
    {
        foo(); // calling A class's foo() method
    }
    
    public static synchronized void foo()
    {
        System.out.println("Calling B class's synchronized method bar()");
        B.bar();
    }
}

class B implements Runnable
{
    Thread t;
    
    B(String name)
    {
        t = new Thread(this, name);
        t.start();
    }
    
    public void run()
    {
        bar(); // calling B class's bar method
    }
    
    public static synchronized void bar()
    {
        System.out.println("Calling A class's synchronized method foo()");
        A.foo();
    }
}

class DeadlockDemo
{
    public static void main(String[] args)
    {
        new A("Thread 1");
        new B("Thread 2");
        
        System.out.println("Program finished!");
    }
}
