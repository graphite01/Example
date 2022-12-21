using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosY = 3;

            // プレイヤが地上(高さ0以上の位置)にいる場合は走る
            // そうでなければ水中にいると見なして泳ぐ
            if (playerPosY >= 0)
            {
                Console.WriteLine("走る!");
            }
            else
            {
                Console.WriteLine("泳ぐ!");
            }
        }
    }
}