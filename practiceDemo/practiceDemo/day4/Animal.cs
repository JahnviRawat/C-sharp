using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceDemo.day4
{
    internal abstract class Animal
    {
        public abstract void makeSound();
    }

    internal class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("sound Made by Dog");
        }
    }

    internal class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("sound Made by Cat");
        }
    }
}
