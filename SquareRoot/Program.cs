using System;
//Здравйте приятели понеже нас малко ни прецакаха и ни пуснаха от Basic направо на ООП 
//ще се радвам ако ми посочите грешките и начинът по който мога да ги поправя, Благодаря !!


namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            double number = 0;
            double sqrt = 0;
            try
            {
             number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Number must be a positive");
                }
                sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
            }
            catch  (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be positive !!");
            }
            catch (FormatException)
            {
               
                Console.WriteLine("Invalid Format the input must be a valid number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
