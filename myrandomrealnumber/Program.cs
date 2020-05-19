using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0,101);
            int input;

            while (true)
            {
                Console.Write("숫자를 입력해주세요>>");
                input = int.Parse(Console.ReadLine());

                if (number > input)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                }
                else if(number<input)
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                }
                else
                {
                    Console.WriteLine("정답!!");
                    break;
                }
            }
        }
    }
}
