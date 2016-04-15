using System;

//Здравйте приятели понеже нас малко ни прецакаха и ни пуснаха от Basic направо на ООП 
//ще се радвам ако ми посочите грешките и начинът по който мога да ги поправя, Благодаря !!

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            int[] number = new int[10];


            for (int i = 0; i < number.Length; i++)
            {

                number[i] = ReadNumbers(start + 1, end - (number.Length - i));
                start = number[i];
            }
            Console.WriteLine("Your number are: ");
            Console.WriteLine(string.Join(",", number));
        }
        public static int ReadNumbers(int start, int end)
        {
            try
            {
                string userInput = Console.ReadLine();
                int num;
                bool succesParsed = int.TryParse(userInput, out num);
                if (!succesParsed || num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException("You need to enter a valid number !!");
                }
                return num;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You have enter invalid number , please enter new number!!");

                return ReadNumbers(start, end);
            }
        }
    }
}
