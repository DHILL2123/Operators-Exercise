namespace OperatorExercise
{
    public class Program
    {
        //Exercise 1

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)



                Console.WriteLine($"When {a} is divided by {b} the results are {quotient} remainder {remainder}.");


            //Exercise 2


            Console.WriteLine("Please enter the radius of your circle.");

            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)
        {

            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }






    }
}