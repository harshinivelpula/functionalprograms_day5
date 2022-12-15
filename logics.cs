using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicsforcoreprograms5
{ 
    public class logics
    { 
        public static void CheckingVowelOrConsonant()
        {
            Console.WriteLine("Enter a character to find a vowel");
            char name = Convert.ToChar(Console.ReadLine());
            if (name == 'a' || name == 'e' || name == 'i' || name == 'o' || name == 'u')
            {
                Console.WriteLine("The given character" + name + " is a vowel");
            }
            else
            {
                Console.WriteLine("The given character" + name + " is not a vowel");
            }
        }
        //prime factorization
        public static void Factor()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime");
        }
        //even or odd
        public static void Check_Even_Or_Odd()
        {
            int number;
            Console.WriteLine("Enter the Number to check Even or Odd ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        //leap year
        public static void Leap_Year()
        {
            int year = 2022;
            if (year > 1000 && year < 9999)
            {
                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine("Leay year");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
        //check large among three
        public static void Largest_Among_Three_Numbers()
        {

            Console.WriteLine("Enter first number");
            string str1 = Console.ReadLine();
            int num1 = Int32.Parse(str1);
            Console.WriteLine("Enter second number");
            string str2 = Console.ReadLine();
            int num2 = Int32.Parse(str2);
            Console.WriteLine("Enter third number");
            string str3 = Console.ReadLine();
            int num3 = Int32.Parse(str3);
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is greatest");
                }
                else
                {
                    Console.WriteLine(num3 + "  is greatest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    if (num2 > num1)
                    {
                        Console.WriteLine(num2 + " is greatest ");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " is greatest ");
                    }
                }
            }
        }
        //check power of 2
        public static void Power_Of_2()
        {
            Console.WriteLine("Enter a number  ");
            string inputByUser = Console.ReadLine();
            int numVal = Int32.Parse(inputByUser);
            if (numVal >= 0 || numVal < 31)
            {
                int temp = 1;
                for (int i = 0; i < numVal; i++)
                {
                    temp = 2 * temp;
                    Console.WriteLine(temp);
                }
            }
        }
        //swap 2 numbers
        public static void Swap_Two_Number()
        {
            int num1 = 40;
            int num2 = 33;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapping of number is  : " + num1 + " " + num2);
        }
        //flipcoin
        public static void FlipCoinMethod()
        {
            {

                int head = 0, tail = 0, headPer, tailPer;
                Console.WriteLine("Flipping of coin");
                Console.WriteLine("Enter a value for number of flips");
                int val1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < val1; i++)
                {
                    Random random = new Random();
                    int coin = random.Next(0, 2);
                    if (coin == 0)
                    {
                        Console.WriteLine("Its head");
                        head++;
                    }
                    else
                    {
                        Console.WriteLine("Its tail");
                        tail++;
                    }
                }
                headPer = head * 100 / val1;
                tailPer = tail * 100 / val1;
                Console.WriteLine("total no of head count: " + head);
                Console.WriteLine("total no of tail count: " + tail);
                Console.WriteLine("Percentage of head: " + headPer + "%");
                Console.WriteLine("Percentage of tail: " + tailPer + "%");
            }
        }
        //check harmonic series
            public static void Harmonic()
            {
                Console.WriteLine("Enter a value to find nth harmonic series");
                int H = Convert.ToInt32(Console.ReadLine());
                if (H != 0)
                {

                    for (int i = 1; i <= H; i++)
                    {

                        Console.Write("1/{0}+", i);

                    }
                }

                else

                {
                    Console.WriteLine("you have entered in valied value");
                }
            }
        //quotitent & remainder
        public static void CheckingQuotientAndReminder()
        {
            Console.WriteLine("Enter a value for divident:");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divident / divisor;
            int reminder = divident % divisor;
            Console.WriteLine("Quotient" + quotient);
            Console.WriteLine("Reminder" + reminder);
        }
    }
}
