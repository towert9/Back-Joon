using System;
using System.Collections;
using System.Collections.Generic;

namespace no_1935
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> number = new Stack<double>();
            Dictionary<int, int> keys= new Dictionary<int, int>();

            var lineCount = Console.ReadLine();
            var postfix = Console.ReadLine();

            for(int i = 0; i< Convert.ToInt32(lineCount); ++i)
            {
                keys.Add(65 + i, Convert.ToInt32(Console.ReadLine()));
            }

            int temp = 0;
            for(int i = 0; i< postfix.Length; ++i)
            {
                temp = Convert.ToInt32(postfix[i]);
                if(temp >= 65 && temp <= 90 )
                {
                    number.Push(keys[temp]); 
                }
                else
                {
                    number.Push(Calculation(number.Pop(), number.Pop(), postfix[i]));
                }
            }
            var str = Math.Round(number.Pop(),2);
            Console.WriteLine(str.ToString("N2"));
        }

        static double Calculation(double b, double a, char e)
        {
            double num = 0;
            switch(e){
                case '*':
                    num = a*b;
                    break;
                case '/':
                    num = a/b;
                    break;
                case '+':
                    num = a+b;
                    break;
                case '-':
                    num = a-b;
                    break;
            }
            return num;
        }
    }
}