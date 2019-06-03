﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHieracy
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCredit = 0.0M;
            SavingsAccount sa = new SavingsAccount(1000.25M, 0.1M);

            Console.WriteLine("Beginning balance is {0:C}", sa.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: {0:C}", totalCredit);
            sa.Credit(totalCredit);//add credit to balance
            Console.WriteLine("ending balance is: {0:C}", sa.Balance);
            Console.WriteLine("=====================================");

            //checking account has a fee for every transaction
            CheckingAccount ca = new CheckingAccount(1000.25M, 5.50M);
            Console.WriteLine("Beginning balance is {0:C}", ca.Balance);
            //asking the user to input the amout the want to add to there acount
            Console.WriteLine("===================================");
            Console.WriteLine("How much do you want to add to the account");
            string cred = Console.ReadLine();
            decimal Incred = Convert.ToDecimal(cred);
            ca.Credit(Incred); //this adds to the account (-fee)
            Console.WriteLine("The current balance is {0:C}", ca.Balance);
            Console.WriteLine("===================================");
            Console.WriteLine("How much do you want to withdraw to the account");
            string dred = Console.ReadLine();
            decimal Indeb = Convert.ToDecimal(dred);
            ca.Debit(Indeb);//taken from the account (-fee)
            Console.WriteLine("Ending balance is {0:C}", ca.Balance);

            Console.ReadLine();
        }
    }
}
