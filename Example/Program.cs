using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            // 変数aに「10」を代入する
            a = 10;

            // 2回デクリメントして結果を表示する
            a--;
            a--;
            Console.WriteLine(a);

            // 「/＝」演算子を使って「4」で割り、結果を表示する
            a /= 4;
            Console.WriteLine(a);
        }
    }
}