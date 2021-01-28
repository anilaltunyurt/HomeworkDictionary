using System;

namespace HomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> month = new MyDictionary<int, string>();
            month.Add(1, "Ocak");
            month.Add(2, "Şubat");
            month.Add(3, "Mart");
            month.Add(4, "Nisan");
            month.Add(5, "Mayıs");
            month.Add(6, "Haziran");
            month.Add(7, "Temmuz");
            month.Add(8, "Ağustos");
            month.Add(9, "Eylül");
            month.Add(10, "Ekim");
            month.Add(11, "Kasım");
            month.Add(12, "Aralık");


            int k = 0;

            for (int m = 0; m < month.Length; m++)
            {
                Console.WriteLine(month.key[m] + " = " + month.value[m]);
                k = m + 1;
            }
        }
    }
}
