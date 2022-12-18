using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数の初期化
            int money = 5000; // 現在の所持金
            int salary = 800; // 時給
            int hour = 2; // 働いた時間

            // 現在の所持金の合計を計算して表示
            int sum = money + salary * hour;
            Console.WriteLine(sum);
        }
    }
}