namespace Assignment_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        //square
        int triangleBase = 5, triangleHeight = 3;
        int squareBase = 4, squareHeight = 4;
        int rectangleBase = 6, rectangleHeight = 5;

        double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
        double squareArea = CalculateSquareArea(squareBase, squareHeight);
        double rectangleArea = CalculateRectangleArea(rectangleBase, rectangleHeight);

         Console.WriteLine($"A triangle with a base length of {triangleBase} and a height of {triangleHeight} has an area of {triangleArea}.");
         Console.WriteLine($"A square with a base length of {squareBase} and a height of {squareHeight} has an area of {squareArea}.");
         Console.WriteLine($"A rectangle with a base length of {rectangleBase} and a height of {rectangleHeight} has an area of {rectangleArea}.");


        }
        static double CalculateTriangleArea(int b, int h)
        {
        return 0.5 * (b * h);
        }

           static double CalculateSquareArea(int b, int h)
        {
        return b * h;
        }

        static double CalculateRectangleArea(int b, int h)
        {
        return b * h;
        }

        //triangle
        

        //rectangle


    }
}