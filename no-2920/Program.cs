using System;

namespace no_2920
{
    class Program
    {
        static void Main(string[] args)
        {
            string note = Console.ReadLine().Replace(" ","");
            string discrimination = "mixed";

            Func<int, string> myFunc = (comparison)=>{
                for(int i = 1; i < note.Length ; ++i)
                {
                    if(note[i-1] - note[i] != comparison)// 배열의 앞 뒤의 수를 빼서 1과 -1검사한다.
                    {
                        return "mixed";
                    }    
                }
                return comparison == 1 ? "descending" : "ascending";
            };

            if(note[0] == '1')
            {
                discrimination = myFunc(-1);
            }
            else if(note[0] == '8')
            {
                discrimination = myFunc(1);
            }

            Console.WriteLine(discrimination);
        }
    }
}
