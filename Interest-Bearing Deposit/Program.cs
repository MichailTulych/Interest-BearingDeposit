using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Bearing_Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int procent;

            Console.Write("Введите количество средств, внесеннных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад? ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент открыт вклад? ");
            procent = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= years; i++)
            {
                money += money * procent / 100;
                Console.WriteLine($"За: {i} год у вас: {money} средств ");
            }
            Console.ReadKey();
        }
    }
}
