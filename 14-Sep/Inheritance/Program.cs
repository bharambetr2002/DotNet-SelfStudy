using System;

namespace Inheritance
{
    /*
     * Access Modifiers in C#:
     * - private: accessible only within the same class
     * - public: accessible from anywhere
     * - protected: accessible within the same class and derived classes
     * - internal: accessible within the same assembly (project)
     * - protected internal: accessible in derived classes and within the same assembly
     * - private protected: accessible within the same class or derived classes in the same assembly
     *
     * Inheritance Notes:
     * - C# supports single inheritance only (one base class at a time)
     * - Derived classes inherit members from base classes
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of subDerivedClass
            SubDerivedClass subDerived = new SubDerivedClass();

            // Access inherited members from baseClass and derivedClass
            subDerived.i = 1; // from baseClass
            subDerived.j = 2; // from derivedClass
            subDerived.k = 3; // from subDerivedClass itself

            // Output all the values
            Console.WriteLine("Values of inherited and own members:");
            Console.WriteLine("i = " + subDerived.i);
            Console.WriteLine("j = " + subDerived.j);
            Console.WriteLine("k = " + subDerived.k);
        }
    }

    // Base class
    class BaseClass
    {
        public int i; // Accessible from everywhere
    }

    // Derived class inheriting from BaseClass
    class DerivedClass : BaseClass
    {
        public int j; // Accessible from everywhere
    }

    // SubDerivedClass inheriting from DerivedClass
    class SubDerivedClass : DerivedClass
    {
        public int k; // Accessible from everywhere
    }
}
