namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();

            int Added = Add(2, 2);
            Console.WriteLine(Added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int mult = Multiply(2, 5);
            Console.WriteLine(mult); 

            int div = Divide(4, 2);
            Console.WriteLine(div);

            int result = Sum(5, 5, 5, 5, 5);
            Console.WriteLine(result);
        }
        public static void MadLib()
        {
            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! what is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}");

        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum += number;
            }
            return sum;
        }
    }
}
