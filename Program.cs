using System;

namespace OOP_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vasia = new bank_account();
            //var Vasia = new bank_account(111,0, account_types.Credit);
            Console.WriteLine($"Номер счёта {Vasia.GetAccountNumber()}");
            Console.WriteLine($"Тип счёта { Vasia.GetAccountTipe()}");
            Console.WriteLine($"Старый баланс {Vasia.GetBalance()}");
            Vasia.NewBalance(100);
            Console.WriteLine($"Новый баланс {Vasia.GetBalance()}");
            Console.ReadKey();
        }
        public enum account_types
        {
            Current,
            Calculated,
            Credit,
            Deposit
        }
        class bank_account{
            private readonly int account_number = 111;
            private double balance = 0;
            private readonly account_types account_type = account_types.Credit;

            /*
            public bank_account(int account_number, double balance, account_types account_type)
            {
                this.account_number = account_number;
                this.balance = balance;
                this.account_type = account_type;
            }
            */

            public int GetAccountNumber()
            {
                return this.account_number;
            }

            public double GetBalance()
            {
                return this.balance;
            }

            public void NewBalance(double value)
            {
                this.balance = value;
            }

            public account_types GetAccountTipe()
            {
                return this.account_type;
            }
            
        }
           /* 
        public int account_number
        {
            get
            {
                return this.account_number;
            }
        }
        public double balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        public account_types account_type
        {
            get
            {
                return this.account_type;
            }
        } */ 
    }
}
