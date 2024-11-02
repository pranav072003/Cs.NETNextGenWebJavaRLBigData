// Program demonstrating dynamic method dispatch
class Animal
{
  public void sound()
  {
    System.out.println("Animal is making a sound");
  }
}

class Dog extends Animal
{
  public void sound()
  {
    System.out.println("Dog is barking");
  }
}

class Cat extends Animal
{
  public void sound()
  {
    System.out.println("Cat is meowing");
  }
}

class JavaLabFileExp1
{
  public static void main(String[] args)
  {
    Animal a = new Animal();
    Dog d = new Dog();
    Cat c = new Cat();
    a.sound();

    // making a point to Dog class reference
    a = d;
    a.sound();

    // making a point to Cat class reference
    a = c;
    a.sound();
  }
}