using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int mapType = 2;

            // 地形の種類によってHPの値を増減する
            if (mapType == 1) //回復地形の場合
            {
                hp += 10;
            }
            else if (mapType == 2) //毒地形の場合
            {
                hp -= 5;
            }
            else if (mapType == 3) //罠の場合
            {
                hp = 0;
            }
            else //上記以外は全て通常の地形
            {
                Console.WriteLine("HPの変化なし");
            }

            Console.WriteLine("HP=" + hp);
        }
    }
}