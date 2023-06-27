using System.Drawing;
namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Appearence
            Console.Title = "Average Calculator";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //Vars
            double numQuantity;
            double numInputed;
            double addInputed = 0;

            //Calculator
            Console.WriteLine("How many numbers you want to input?");
            numQuantity = Convert.ToDouble(Console.ReadLine());
            
            for (double i = 0; i < numQuantity; i++){
                double numShow = i + 1;
                Console.WriteLine(numShow + ". Input the number:");
                numInputed = Convert.ToDouble(Console.ReadLine());
                addInputed += numInputed;
            }

            double averageResult = addInputed / numQuantity;
            Console.WriteLine("This is the average: " + averageResult);

            Console.ReadKey();
        }
    }
}