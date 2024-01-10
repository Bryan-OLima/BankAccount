using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
    internal class Account {

        private static int tax = 5;

        private string? _name;
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }
  
        //constructors
        private Account() {
        }

        public  Account(string name, int accountNumber) : this() {
            _name = name;
            AccountNumber = accountNumber;
        }

        public Account(string name, int accountNumber, double initialDeposit) : this(name, accountNumber){
            Balance = initialDeposit;
        }

        //custom properties
        public string Name {
            get { return _name; }
            set { 
                if(value.Length > 2) {
                    _name = value;
                }
            }
        }

        //methods

        public void Deposit(double deposit) {
            Balance += deposit;
        }

        public void WithDraw(double withdraw) {
            if(withdraw != null || withdraw > 0) {
                Balance = (Balance - tax) - withdraw; 
            }
        }

        public override string ToString() {
            return $"Account {AccountNumber}, Owner: {_name}, Balance: ${Balance} ";
        }
    }


}
