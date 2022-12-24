using System;

namespace Example
{
    class Program
    {
        // 引数に商品名を受け取り、
        // 商品名に応じた値段を表示するメソッド
        static void Shop(string itemName)
        {
            Console.WriteLine("いらっしゃいませ!");

            if (itemName == "薬草")
            {
                Console.WriteLine(itemName + "は100円です");
            }
            else if (itemName == "棍棒")
            {
                Console.WriteLine(itemName + "は1500円です");
            }
            else
            {
                Console.WriteLine("売り切れです");
            }
        }

        static void Main(string[] args)
        {
            // 「薬草」を引数に渡してShopメソッドを呼び出す
            Shop("薬草");
        }
    }
}