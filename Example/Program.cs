using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; // 合計値を保持する変数
            int num = 1;

            while (true)
            {
                // 合計値にnumの値を加算する
                sum += num;

                // 現在の合計値を表示
                Console.WriteLine(sum);

                // 合計値が500を超えたらwhile文を抜ける
                if (sum >= 500)
                {
                    break;
                }

                // numの値を1増やす
                num++;
            }
            Console.WriteLine("計算終了");
        }
    }
}