using System;

namespace Example
{
    class Program
    {
        // 引数の値が偶数か奇数化を表示するメソッド
        static void ShowEve0r0dd (int num)
        {
            if ((num % 2) == 0)
            {
                Console.WriteLine("偶数です");
            }
            else
            {
                Console.WriteLine("奇数です");
            }
        }

        static void Main(string[] args)
        {
            // ShowEve0r0ddメソッドを呼び出す
            ShowEve0r0dd(3);
        }
    }
}