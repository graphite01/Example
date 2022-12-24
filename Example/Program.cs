using System;

namespace Example
{
    class Program
    {
        // 商品名を引数に取り、
        // 対応する商品の値段を返すメソッド
        static int Shop(string itemName)
        {
            Console.WriteLine("いらっしゃいませ!");
            int price = 0;

            if (itemName == "薬草")
            {
                Console.WriteLine(itemName + "は100円です");
                price = 100;
            }
            else if (itemName == "棍棒")
            {
                Console.WriteLine(itemName + "は1500円です");
                price = 1500;
            }
            else
            {
                Console.WriteLine("売り切れです");
                price = 0;
            }

            // 引数に対応する商品の値段を返す
            return price;
        }

        static void Main(string[] args)
        {
            int money = 2500;
            Console.WriteLine("所持金は" + money + "円です");
            int price = Shop("薬草");
            money -= price;
            Console.WriteLine("所持金は" + money + "円です");
        }
    }
}