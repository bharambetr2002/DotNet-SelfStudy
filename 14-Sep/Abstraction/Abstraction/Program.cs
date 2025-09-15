using System;

namespace OOPConceptsDemo
{
    // 1. Abstract Class - provides common structure
    abstract class Shape
    {
        public abstract void Draw();  // Abstract method to be implemented by derived classes

        // Virtual method that can be overridden in derived classes
        public virtual void ShowType()
        {
            Console.WriteLine("This is a generic shape.");
        }
    }

    // 2. Interface - defines a contract for classes to implement
    interface IColor
    {
        void SetColor(string color);
    }

    // 3. Derived class - Circle implements Shape and IColor
    class Circle : Shape, IColor
    {
        private string color;

        // Implement abstract method
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }

        // Implement interface method
        public void SetColor(string color)
        {
            this.color = color;
            Console.WriteLine("Circle color set to: " + color);
        }

        // Virtual method that can be overridden by further derived classes
        public virtual void CalculateArea(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }

        // Optionally override ShowType
        public override void ShowType()
        {
            Console.WriteLine("This is a Circle.");
        }
    }

    // 4. Derived class - Cylinder inherits from Circle
    class Cylinder : Circle
    {
        // Override virtual method from Circle
        public override void CalculateArea(double radius)
        {
            Console.WriteLine("Area calculation in Cylinder (overridden for demonstration).");
        }

        // Optionally override ShowType if needed
        public override void ShowType()
        {
            Console.WriteLine("This is a Cylinder.");
        }
    }

    // 5. Sealed Class - Triangle cannot be inherited
    sealed class Triangle : Shape, IColor
    {
        private string color;

        // Implement abstract method
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }

        // Implement interface method
        public void SetColor(string color)
        {
            this.color = color;
            Console.WriteLine("Triangle color set to: " + color);
        }

        // Override and seal the ShowType method to prevent further overrides
        public sealed override void ShowType()
        {
            Console.WriteLine("This is a Triangle.");
        }

        // Normal method specific to Triangle
        public void CalculatePerimeter(int a, int b, int c)
        {
            Console.WriteLine("Perimeter of Triangle: " + (a + b + c));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using abstract class reference with polymorphism
            Shape shape1 = new Circle();
            shape1.Draw();
            shape1.ShowType();

            // Using interface reference
            IColor colorCircle = new Circle();
            colorCircle.SetColor("Red");

            // Using Circle directly
            Circle circle = new Circle();
            circle.Draw();
            circle.SetColor("Green");
            circle.CalculateArea(5);
            circle.ShowType();

            // Using Cylinder which overrides CalculateArea
            Cylinder cylinder = new Cylinder();
            cylinder.Draw();
            cylinder.SetColor("Blue");
            cylinder.CalculateArea(7);
            cylinder.ShowType();

            // Using sealed class Triangle
            Triangle triangle = new Triangle();
            triangle.Draw();
            triangle.SetColor("Yellow");
            triangle.ShowType();
            triangle.CalculatePerimeter(3, 4, 5);

            // Note: Cannot inherit from Triangle or override its ShowType method
        }
    }
}
