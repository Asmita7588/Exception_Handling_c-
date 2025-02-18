using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class BankAccount
    {
        public double balance {  get;  set; }

        public BankAccount(double initaialAmount)
        {
            balance = initaialAmount;
        }

        public void Withdraw(double amount) {

            if (balance < amount)
                throw new InsufficientFundsException("balance is insufficient ! can not withdraw");

                balance -= amount;
                Console.WriteLine(amount + " rs has withdraw successfully.");
                Console.WriteLine("Remaining balance :" +balance);
            
        }
    }
}
