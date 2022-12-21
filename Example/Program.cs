using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            if(num >= 3)
            {
                // numの値が3以上なら「勝ち」と表示
                Console.WriteLine("勝ち");
            }
            else
            {
                // numの値が2以下なら「負け」と表示
                Console.WriteLine("負け");
            }
        }
    }
}