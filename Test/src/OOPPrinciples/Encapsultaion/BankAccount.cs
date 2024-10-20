using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.src.OOPPrinciples.Encapsultaion
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance){
            Deposit(balance);
        }

        public decimal GetBalance(){
            return balance;
        }

        public void Deposit(decimal amount){
            if(amount <= 0){
                throw new ArgumentException("Deposit amount must be positive");
            }
            this.balance += amount;
        }

        public void Withdraw(decimal amount){
            if(amount <= 0){
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if(amount >= balance){
                throw new InvalidOperationException("Insufficient funds");
            }
            this.balance -= amount;
        }
    }
}