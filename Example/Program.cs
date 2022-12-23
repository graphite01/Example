using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f,
                                45.1f, 43.2f, 42.7f };

            // 43kg以下の値だけを表示する
            for (int i = 0; i < weights.Length; i++)
            {
                if (weights[i] <= 43)
                {
                    Console.WriteLine(weights[i]);
                }
            }
        }
    }
}