using System;
using System.Collections.Generic;

namespace no_9466
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < t; ++i){
                var playerCount = Convert.ToInt32(Console.ReadLine());
                var playerIndex = new int[playerCount + 1];
                var playerAdd = new int[playerCount + 1];
                var players = Console.ReadLine().Split(' ');

                for(int j = 1; j <= playerCount; ++j){
                    var index = Convert.ToInt32(players[j - 1]);
                    playerIndex[j] = index;
                    playerAdd[index] += 1;
                }

                Queue<int> q = new Queue<int>();
                for(int j = 1; j <= playerCount; ++j){
                    if(playerAdd[j] == 0){
                        q.Enqueue(j);
                    }
                }
                int notCount = 0;
                while(q.Count != 0){
                    var index = q.Dequeue();
                    notCount += 1;
                    playerAdd[playerIndex[index]] -= 1;
                    if(playerAdd[playerIndex[index]] == 0)
                        q.Enqueue(playerIndex[index]);
                }
                Console.WriteLine(notCount);
            }
        }
    }
}
