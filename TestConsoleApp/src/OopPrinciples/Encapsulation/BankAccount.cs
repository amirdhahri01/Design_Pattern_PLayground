using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsoleApp.src.OopPrinciples.Encapsulation{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal balance){
            Disposit(balance);
        }
        public void Disposit(decimal balance){
            if(balance <= 0){
                throw new ArgumentException("Disposit amount must be positive");
            }
            this.balance = balance;
        }

        public void Withdraw(decimal amount){
            if(amount <= 0){
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if(amount > this.balance){
                throw new InvalidOperationException("Insufficient funds");
            }
            this.balance -= amount;
        }

        public decimal getBalance(){
            return this.balance;
        }
    }
}
