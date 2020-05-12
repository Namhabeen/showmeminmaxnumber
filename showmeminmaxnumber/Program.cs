using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {

         string input_num;
         int max_num = 0;
         int min_num = 0;

            for (int i = 0; i < 5; i++)
            {

                Console.Write("숫자를 입력해주세요: ");
                input_num = Console.ReadLine();
                if (i == 0)
                {
                    max_num = int.Parse(input_num);
                    min_num = int.Parse(input_num);
                }

                else
                {
                    if (int.Parse(input_num) > max_num)
                    {
                        max_num = int.Parse(input_num);
                    }
                    if (int.Parse(input_num) < min_num)
                    {
                        min_num = int.Parse(input_num);
                    }
                }

            }

         Console.WriteLine("-----------------------------");
         Console.WriteLine("가장 큰 수: " + max_num);
         Console.WriteLine("가장 작은 수: " + min_num);

        }
    }
}
