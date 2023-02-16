using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.BaseFunctions
{
    // Abstract class
    abstract class AbstractClass
    {
        // Abstract method (Does not have a body)
        public abstract void AnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (Inherit from AbstractClass)

    class DerivedAbstractClass : AbstractClass
    {
        public override void AnimalSound()
        {
            // The body of AnimalSound() is provided here
            Console.WriteLine("The dog says: bow bow");
        }
    }

}
