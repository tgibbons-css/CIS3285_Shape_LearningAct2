using System;

namespace Shape_LearningAct2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.setWidth(3);
            rectangle.setHeight(4);
            rectangle.calculateArea();

            Triangle triangle = new Triangle();
            triangle.setWidth(3);
            triangle.setHeight(4);
            triangle.calculateArea();

            if (rectangle.CompareTo(triangle) < 0)
            {
                Console.WriteLine("The rectangle is less than the triangle.");
            }
            else if (rectangle.CompareTo(triangle) == 0)
            {
                Console.WriteLine("The rectangle is equal to the triangle.");
            }
            else
            {
                Console.WriteLine("The rectangle is greater than the triangle.");
            }
        }
    }
}
