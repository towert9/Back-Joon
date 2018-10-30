using System;

namespace no_2609
{
    class Program
    {
        static void Main(string[] args)
        {   
            var numbers = Console.ReadLine().Split(' ');
            lcmAndGcd(int.Parse(numbers[0]), int.Parse(numbers[1]));
        }

        // 최대공약수 구하는 함수 - 유클리드 호제법 -> A는 B보다 크거나 같아야 성립.
        // https://ko.wikipedia.org/wiki/%EC%9C%A0%ED%81%B4%EB%A6%AC%EB%93%9C_%ED%98%B8%EC%A0%9C%EB%B2%95
        static int gcd(int a,int b)
        {
            if( a % b == 0 )
                return b;
            else
                return gcd(b, a % b);
        }

        //최소공배수 최대공약수 구하고 출력하는 함수
        static void lcmAndGcd(int a, int b)
        {
            var gcdNum = (a < b) ? gcd(b, a) : gcd(a, b);
            Console.WriteLine(gcdNum);            
            Console.WriteLine(a * b / gcdNum); // -> A * B / 최대공약수 = 최소 공배수
        }
    }
}
