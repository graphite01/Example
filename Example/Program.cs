using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            // プレイヤの位置とミサイルの位置が等しくなければ
            // ミサイルの移動を繰り返す
            while (playerPosX != missilePosX)
            {
                Console.WriteLine("missile at " + missilePosX);
                missilePosX--; // ミサイルを左に動かす
            }
            Console.WriteLine("HIT");
        }
    }
}