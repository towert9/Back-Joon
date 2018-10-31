using System;
using System.Collections.Generic;
using System.Text;
namespace no_2493
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> towers = new Stack<int>();

            var count = Convert.ToInt32(Console.ReadLine());
            var towerNum = Console.ReadLine().Replace(" ","");

            for(int i = 0; i< count; ++i){
                towers.Push(Convert.ToInt32(towerNum[i]));
            }            

            var resultStrb = new StringBuilder();
            for(int i = 0; i < count; ++i){
                var pop = towers.Pop();
                var result = 0;
                var tempsCount = towers.Count;
                foreach (var item in towers)
                {
                    if(item > pop){
                        result = tempsCount;
                        break;
                    }
                    tempsCount -= 1;
                }
                resultStrb.Insert(0, (towers.Count == 0) ? result.ToString() : string.Format(" {0}",result));
            }
            
            Console.WriteLine(resultStrb.ToString());
        }
    }
}
