using System;

namespace no_1003
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[,] fb = new int[41,2];

            fb[0,0] = 1; fb[0,1] = 0; // 0
            fb[1,0] = 0; fb[1,1] = 1; // 1

            for(int i = 2; i < 41; ++i) //2 ~ 40 까지
            {
                fb[i,0] = fb[i-1,1];
                fb[i,1] = fb[i-1,1] + fb[i-2,1];
            }
            
            var num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0 ; i < num ; i++)
            {
                var num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fb[num2,0]+" "+fb[num2,1]);
            }
        }
    }
}
