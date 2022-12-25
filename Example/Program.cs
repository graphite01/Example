﻿using System;

namespace Example
{
    class Program
    {
        // int型の引数を3つ受け取り、
        // その平均値をfloat型で返すメソッド
        static float CalcAverage (int a, int b, int c)
        {
            float average;
            average = (a + b + c) / 3.0f;

            // float型で平均値を返す
            return average;
        }

        static void Main(string[] args)
        {
            // CalcAverageメソッドを呼び出して戻り値を表示
            float answer = CalcAverage(1, 5, 10);
            Console.WriteLine(answer);
        }
    }
}