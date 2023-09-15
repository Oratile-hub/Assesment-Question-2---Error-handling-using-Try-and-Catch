using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_Question_2___Error_handling_using_Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

        try
            {

                Console.WriteLine("Enter your first number ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your second number");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("First number devided by second number: num1/num2 = ");
                Console.WriteLine(number1 / number2);

            }

        catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //freeze console
            Console.Read();

        }
    }
}
