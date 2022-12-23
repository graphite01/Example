using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列を初期化する
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f,
                                43.2f, 42.7f, 41.5f, 41.4f, 41.9f };

            // 「変数名.Length」を使って全要素にアクセスする
            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine(weights[i]);
            }
        }
    }
}