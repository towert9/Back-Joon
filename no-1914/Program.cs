using System;
using System.Text;
using System.Numerics;

namespace no_1914
{
    class Program
    {
        static StringBuilder strb = new StringBuilder();
        static void Main(string[] args)
        {
            var lineNum = Convert.ToInt32(Console.ReadLine());
            strb.AppendLine(((BigInteger)(Math.Pow(2, lineNum)) - (BigInteger)1).ToString());
            if(lineNum <= 20)
            {
                Hanoi(lineNum, 1, 2, 3);
            }

            Console.Write(strb.ToString());
        }
        static void Hanoi(int num, int from, int by, int to)
        {
            if(num == 1)
            {
                strb.AppendLine(string.Format("{0} {1}", from, to));
            }
            else
            {
                Hanoi(num - 1, from, to, by);
                strb.AppendLine(string.Format("{0} {1}", from, to));
                Hanoi(num - 1, by, from, to);
            }
        }
    }
}
