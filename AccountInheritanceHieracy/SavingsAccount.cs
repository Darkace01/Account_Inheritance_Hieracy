using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHieracy
{
    class SavingsAccount : Account
    {
        private decimal _interestRate;


        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("Interest rate must be greater than Zero");
            }
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
