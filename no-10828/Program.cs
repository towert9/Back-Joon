using System;
using System.Collections.Generic;
namespace no_10828
{
    class Program
    {
        class MyStack
        {
            private List<int> list = new List<int>();

            public void Push(int data){
                list.Add(data);
            }

            public int Pop(){
                int temp;
                if(list.Count == 0){
                    temp = -1;
                }else{
                    temp = list[list.Count -1];
                    list.RemoveAt(list.Count -1);
                }
                return temp;
            }

            public int Top(){
                int temp;
                if(list.Count == 0){
                    temp = -1;
                }else{
                    temp = list[list.Count -1];
                }
                return temp;
            }

            public int Size(){
                return list.Count;
            }

            public int Empty(){
                return Size() == 0? 1 : 0;
            }
        }
        static void Main(string[] args)
        {
            var orderCount = Console.ReadLine();
            MyStack myStack = new MyStack();

            for(int i = 0, count = Convert.ToInt32(orderCount) ; i < count; ++i){
                var input = Console.ReadLine().Split(' ');
                switch(input[0]){
                    case "push":
                        myStack.Push(Convert.ToInt32(input[1]));
                        break;
                    case "pop":
                        Console.WriteLine(myStack.Pop());
                        break;
                    case "top":
                        Console.WriteLine(myStack.Top());
                        break;
                    case "size":
                        Console.WriteLine(myStack.Size());
                        break;
                    case "empty":
                        Console.WriteLine(myStack.Empty());
                        break;
                }
            }
        }
    }
}
