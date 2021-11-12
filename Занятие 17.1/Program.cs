using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<long> bankAccount1 = new BankAccount<long>(40502840200,  "Иванов Иван Петрович", 1114500);
            bankAccount1.Print();
            Console.WriteLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>("U4054FA00", "Сидоров Александр Александрович", 14500);
            bankAccount2.Print();
            Console.ReadKey();
        }
    }

    public class BankAccount<T>
    {
        private T number { get; set; }
        private double balance { get; set; }
        private string fio { get; set; }


        public BankAccount(T number, string fio, double balance)
        {
            this.number = number;
            this.fio = fio;
            this.balance = balance;
        }

        public void Print()
        {
            Console.WriteLine("Номер счета: {0} \nФИО: {1} \nБаланс: {2}", number, fio, balance);
        }
    }
}
