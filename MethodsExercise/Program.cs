namespace MethodsExercise
{
    public class Program
    {

        static public int Sum(int num1, int num2)
        {

            return num1 + num2;
        }

        static public int Multiply(int num1, int num2, int num3)
        {

            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {

            // Exercise 2 -----------------------------------------

            var amountOfCars = Sum(1, 2);
            var blah = Multiply(1, 2, 3);

            Console.WriteLine($"Sum:{amountOfCars}, Multiply:{blah}");

            // Exercise 1 ------------------------------------------

            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}. What is your favorite Color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"{favColor} is a good color. What is your favorite Animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"What is your favorite Band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{favBand} is a great Band");
        }
    }
}
