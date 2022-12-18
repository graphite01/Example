using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // int型の変数を2つ用意
            int a = 15;
            int b = 2;

            float answer;   // 浮動小数点の結果を代入する変数を用意

            // int型の値に小数点を掛けて計算する場合
            answer = a * 1.0f / b;
            Console.WriteLine(answer);

            // 暗黙のキャストでint型をfloat型にして計算する場合
            float c = a;
            answer = c / b;
            Console.WriteLine(answer);
        }
    }
}