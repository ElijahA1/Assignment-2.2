namespace Assignment_2._2
{
    internal class Program
    {
        // Exercise 2
        static void userInputForShapeArea()
        {
            Console.WriteLine("Input \"1\" to calculate the area of a circle");
            Console.WriteLine("Input \"2\" to calculate the area of a square");
            Console.Write("Make a selection: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("Enter the radius: ");
                    Circle circle = new Circle();
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                    circle.calculateArea();
                    break;
                case 2:
                    Console.Write("Enter the length of a side: ");
                    Square square = new Square();
                    square.lengthOfSide = Convert.ToDouble(Console.ReadLine());
                    square.calculateArea();
                    break;
                default:
                    Console.WriteLine("Please make a proper selection");
                    userInputForShapeArea();
                    break;
            }   
        }

        // Exercise 3
        static void userInputForMathyMath()
        {
            Console.WriteLine("Input \"1\" to add two numbers");
            Console.WriteLine("Input \"2\" to multiply two or three numbers");
            Console.Write("Make a selection: ");
            uint userInput = Convert.ToUInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("\nEnter the first number: ");
                    decimal number1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\nEnter the second number: ");
                    decimal number2 = Convert.ToDecimal(Console.ReadLine());
                    MathyMath.add(number1, number2);
                    break;
                case 2:
                    Console.WriteLine("Input \"1\" to multiply two numbers");
                    Console.WriteLine("Input \"2\" to multiply three numbers");
                    Console.Write("Make a selection: ");
                    uint newInput = Convert.ToUInt32(Console.ReadLine());
                    if (newInput == 1)
                    {
                        Console.Write("\nEnter the first number: ");
                        float mul1 = float.Parse(Console.ReadLine());
                        Console.Write("\nEnter the second number: ");
                        float mul2 = float.Parse(Console.ReadLine());
                        MathyMath.multiply(mul1, mul2);
                    }
                    else if (newInput == 2)
                    {
                        Console.Write("\nEnter the first number: ");
                        float mul1 = float.Parse(Console.ReadLine());
                        Console.Write("\nEnter the second number: ");
                        float mul2 = float.Parse(Console.ReadLine());
                        Console.Write("\nEnter the third number: ");
                        float mul3 = float.Parse(Console.ReadLine());
                        MathyMath.multiply(mul1, mul2, mul3);
                    } else
                    {
                        Console.WriteLine("Please use valid inputs");
                        userInputForMathyMath();
                    }
                        break;
                default:
                    Console.WriteLine("Please make a proper selection");
                    userInputForMathyMath();
                    break;
            }
        }
        static void Main(string[] args)
        {
            userInputForShapeArea();
            userInputForMathyMath();
        }
    }
}
