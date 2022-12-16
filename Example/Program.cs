using System;

namespace Example
{

    class Program
    {
        static void Main(string[] args)
        {
            // 変数の宣言
            int money;   // 所持金を代入する変数
            string name; // 名前を代入する変数
            int answer; // 計算結果

            // 変数に値を代入する
            money = 5000;
            name = "きたむら";


            Console.WriteLine(money); // 所持金を表示
            Console.WriteLine(name); // 名前を表示

            // 加算
            answer = 3 + 4;
            Console.WriteLine(answer);

            // 減算
            answer = 12 - 18;
            Console.WriteLine(answer);

            // 乗算
            answer = 2 * 7;
            Console.WriteLine(answer);

            // 除算
            answer = 18 / 3;
            Console.WriteLine(answer);

            // 剰余
            answer = 21 % 5;
            Console.WriteLine(answer);
        }
    }
}