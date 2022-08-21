using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        class Account<T>
        {
            private T Num { get; set; }
            private string Name { get; set; }
            private double Balance { get; set; }

            public void Input()
            {
                Console.WriteLine("Введите номер счета");
                string stringNum = Console.ReadLine();
                Num = (T)Convert.ChangeType(stringNum, typeof(T));
                Console.WriteLine("Введите фамилию, имя, отчество");
                Name = Console.ReadLine();
                Console.WriteLine("Введите баланс");
                Balance = Convert.ToDouble(Console.ReadLine());
            }

            public string GetInfo()
            {
                return $"{Num} {Name} {Balance}";
            }
        }
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            Account<string> account2 = new Account<string>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
