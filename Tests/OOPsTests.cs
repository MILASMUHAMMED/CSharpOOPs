using CSharpTraining.BaseFunctions;
using NUnit.Framework;
using System;

namespace CSharpTraining
{
    public class OOPsTests
    {
        [Test]
        public void SingleInheritance()
        {
            SingleInheritanceChild singleInheritanceChild = new SingleInheritanceChild();
            singleInheritanceChild.Eat();
            singleInheritanceChild.Bark();
        }

        [Test]
        public void MultiLevelInheritance()
        {
            MultiLevelInheritanceChild multiLevelInheritanceChild = new MultiLevelInheritanceChild();
            multiLevelInheritanceChild.Eat();
            multiLevelInheritanceChild.Bark();
            multiLevelInheritanceChild.Weep();

        }

        [Test]
        public void HierarchicalInheritance()
        {
            SingleInheritanceChild singleInheritanceChild = new SingleInheritanceChild();
            singleInheritanceChild.Eat();
            singleInheritanceChild.Bark();

            HierarchicalInheritanceChild hierarchicalInheritanceChild = new HierarchicalInheritanceChild();
            hierarchicalInheritanceChild.Eat();
            hierarchicalInheritanceChild.Meow();

        }

        [Test]
        public void Polymorphism()
        {
            Polymorphism polymorphism = new Polymorphism();
            Console.WriteLine(polymorphism.Add(2, 3));
            Console.WriteLine(polymorphism.Add(2.2, 3.3, 5.5));
            Console.WriteLine(polymorphism.Add(2.2m, 3.3m, 4.4m));

        }

        [Test]
        public void Encapsulation()
        {
            var lenght = 10;
            var width = 5;
            var height = 2.5;

            Encapsulation rectangle = new Encapsulation(lenght, width, height);

            Console.WriteLine(rectangle.SurfaceArea());
            Console.WriteLine(rectangle.LateralSurfaceArea());
            Console.WriteLine(rectangle.Volume());
        }

        [Test]
        public void Abstraction()
        {
            DerivedAbstractClass derivedAbstractClass = new DerivedAbstractClass(); // Create a DerivedAbstractClass object
            derivedAbstractClass.AnimalSound(); // Call the abstract method
            derivedAbstractClass.Sleep(); // Call the regular method
        }

    }
}