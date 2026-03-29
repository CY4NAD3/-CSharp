using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            //                     inherited method must be: abstract,virtual, or already overriden
            //                     Used with ToString(), polymorphism
            //                     sealed override -> cant override further i.e: Animal->Dog->BullDog
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.speak();
            cat.speak();                     

            Console.ReadKey();
        }
    }
    //abstract class Animal
    //{
    //    public abstract void Speak();       
    //}
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("The animal goes *Brrr*");
        }

    }
    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("The animal goes *Woofff*");
        }

    } 
    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("The animal goes *Meoww*");
        }

    } 
}
