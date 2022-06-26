using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of animals
            string[] animals= {"Dog, ", "Frog, ", "Cat, ","Kitten, ","Tomcat."};
            Console.Write("List of Animals: ");
            //Displaying elements of the Array
             foreach(string anim in animals){
            Console.Write( anim);
             }
             Animal myAnimal = new Animal();  // Create a Animal object
             Animal myDog = new Dog();  // Create a Dog object
             Animal myFrog = new Frog();// Create a Frog object
              Animal myCat = new Cat();// Create a Cat object
               Animal myKitten = new Kitten();// Create a Kitten object
                Animal myTomcat = new Tomcat();// Create a Tomcat object

             myAnimal.animalSound();
             myDog.animalSound();
              myFrog.animalSound();
             myCat.animalSound();
            myKitten.animalSound();
            myTomcat.animalSound();
           
        }
    }
    class Animal  // Base class (parent) 
   {
       public virtual void animalSound() 
       {
             Console.WriteLine("\n(Default-Display)\nName: animal\nAge: nill\nGender: none");
             Console.WriteLine("This animal makes a sound");
       }
   }

     class Dog : Animal  // Derived class (child) 
    {
       public override void animalSound() 
       {
        Console.WriteLine("==========\nName: Dog\nAge: 5years\nGender: Female");
          Console.WriteLine("The dog says: wolf wolf");
       }
    }
      class Frog : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("==========\nName: Frog\nAge: 2years\nGender: Male");
             Console.WriteLine("The frog says: croak croak");
         }
    }
    class Cat : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("==========\nName: Cat\nAge: 3years\nGender: Female");
             Console.WriteLine("The cat says: meow meow");
         }
    }
    class Kitten : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("==========\nName: Kitten\nAge: 3months\nGender: Male");
             Console.WriteLine("The kitten says: meoooow meoooow");
         }
    }
     class Tomcat : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("==========\nName: Tomcat\nAge: 3years\nGender: Male");
             Console.WriteLine("The tomcat says: howl yowl ");
         }
    }
}
