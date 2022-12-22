using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10000;
            int count = 0; // 割った回数を保持

            // while文で「10000」が「100以下」になるまで「2」で割る
            while (num > 100)
            {
                num /= 2;
                count++;
            }

            // 割った回数を表示
            Console.WriteLine(count);
        }
    }
}