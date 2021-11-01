using System;

namespace OOP_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vasia = new bank_account(0, account_types.Credit);
            Console.WriteLine($"Номер счёта {Vasia.account_number}");
            Console.WriteLine($"Тип счёта {Vasia.account_type}");
            Console.WriteLine($"Старый баланс {Vasia.balance}");
            Vasia.balance = 100;
            Console.WriteLine($"Новый баланс {Vasia.balance}");
            Console.ReadKey();
        }
        public enum account_types
        {
            Current,
            Calculated,
            Credit,
            Deposit
        }
        class bank_account
        {
            public int account_number { get; set; }

            public double balance { get; set; }
            public account_types account_type { get; set; }

            private static Random rnd = new Random();

            public bank_account()
            {
                this.account_number = rnd.Next();
            }
            public bank_account(double balance)
            {
                this.account_number = rnd.Next();
                this.balance = balance;
            }
            public bank_account(account_types account_type)
            {
                this.account_number = rnd.Next();
                this.account_type = account_type;
            }
            public bank_account(double balance, account_types account_type)
            {
                this.account_number = rnd.Next();
                this.balance = balance;
                this.account_type = account_type;
            }
        }
    }
}
