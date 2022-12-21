using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1PosX = 2; // プレイヤ1の位置
            int player2PosX = 6; // プレイヤ2の位置

            // プレイヤ1の位置が「2」かつプレイヤ2の位置が「6」の場合、
            // またはプレイヤ1の位置が「6」かつプレイヤ2の位置が「2」の場合に仕掛けを解除
            if ((player1PosX == 2 && player2PosX == 6) || (player1PosX == 6 && player2PosX == 2))
            {
                Console.WriteLine("仕掛け解除");
            }
        }
    }
}