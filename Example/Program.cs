using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            // 常にループする
            while (true)
            {
                // プレイヤとミサイルが衝突したらwhile文を抜ける
                if (playerPosX == missilePosX)
                {
                    break;
                }

                Console.WriteLine("missile at " + missilePosX);
                missilePosX--;
            }
            Console.WriteLine("HIT");
        }
    }
}