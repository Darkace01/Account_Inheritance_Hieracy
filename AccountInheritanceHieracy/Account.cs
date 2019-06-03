using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHieracy
{
    class Account
    {
        //One private instance variable of type decimal to represent the account balance 
        private decimal _balance;

        //constructor that receives an initial balance and uses it to initialize the instance variable with public property
        public Account(decimal balance)
        {
            Balance = balance;
        }

        //The property should validate the inital balance
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        //Method Credit should add an amount to the current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance = Balance + amount;
            else
                throw new Exception("Credited amount must be greater than zero");
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance = Balance - amount;
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }

            return OK;
        }
    }
}
