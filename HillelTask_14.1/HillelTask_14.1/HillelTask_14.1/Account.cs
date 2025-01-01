using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelTask_14._1
{
    class Account
    {
        private string name;
        private int balance { get; set; }

        public int Balance
        {
            get { return balance;  }
        }

        public Account(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }


        public void Deposit(int deposit)
        {
            balance += deposit;
        }

        public void Withdrawal(int withDrawalValue)
        {
            balance -= withDrawalValue;
        }
    }
}
