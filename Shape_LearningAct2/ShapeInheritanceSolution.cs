using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_LearningAct2
{
    public class ShapeInheritanceSolution
    {
        public static readonly int TRIANGLE = 1;
        public static readonly int RECTANGLE = 2;
        public static readonly int ELLIPSE = 3;
        public static readonly int CIRCLE = 4;

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            //Scanner input = new Scanner(System.in);
            int shapeType;
            int height;
            int width;
            Shape shape;
            String playAgain;

            do
            {
                Console.WriteLine("What kind of shape would you like to create? ");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Ellipse");
                Console.WriteLine("4. Circle");
                Console.Write("> ");
                shapeType = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the height? ");
                height = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the width? ");
                width = Convert.ToInt32(Console.ReadLine());

                if (shapeType == TRIANGLE)
                {
                    shape = new Triangle();
                    /*
                    Triangle triangle = new Triangle();
                    triangle.setHeight(height);
                    triangle.setWidth(width);
                    shapes.add(triangle);
                    */
                }
                else if (shapeType == RECTANGLE)
                {
                    shape = new Rectangle();
                }
                else if (shapeType == ELLIPSE)
                {
                    shape = new Ellipse();
                }
                else
                {
                    shape = new Circle();
                }

                shape.setHeight(height);
                shape.setWidth(width);
                shapes.Add(shape);

                Console.Write("Do you want to create another shape? ");
                playAgain = Console.ReadLine();
                Console.WriteLine();
            } while (playAgain.ToLower()=="yes" || playAgain.ToLower()=="y");

            for (int index = 0; index < shapes.Count; index++)
            {
                shape = shapes[index];
                shape.calculateArea();
            }

            Console.WriteLine("Here are your unsorted shapes:");
            for (int index = 0; index < shapes.Count; index++)
            {
                shape = shapes[index];
                Console.WriteLine(shape);
            }

            //Collections.sort(shapes);
            shapes.Sort();


            Console.WriteLine("Here are your sorted shapes:");
            for (int index = 0; index < shapes.Count; index++)
            {
                shape = shapes[index];
                Console.WriteLine(shape);
            }
        }
    }

}
