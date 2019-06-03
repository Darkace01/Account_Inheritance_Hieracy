using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHieracy
{
    class CheckingAccount : Account
    {
        private decimal _fee;

        //constructor should recieve the initial balance, as well as a parameter indicating a fee amount.

        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;

        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Fee cannot be less than Zero");
            }
        }

        //remove fee from account
        public override void Credit (decimal amount)
        {
            base.Credit(amount);
            Balance = Balance - Fee;
        }

        // removes fee from the balance
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance = Balance - Fee;
                return true;
            }
            return false;
        }
    }
}
