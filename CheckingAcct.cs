using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgChallenge
{
    class CheckingAcct 
    {
        private string _ownerFirstName = "";
        private string _ownerLastName = "";
        private decimal _balance = 0.0m;
        private int _withdrawCounter =0;

        public  string AccountOwner;
        public string OwnerFirstName { get { return _ownerFirstName; } set { _ownerFirstName = value; } }
        public string OwnerLastName { get { return _ownerLastName; } set { _ownerLastName = value; } }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        
        public void Deposit (decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw( decimal amount)
        {
            
            Balance -= amount;

        }
        
        public CheckingAcct(string ownersFirstName, string ownersLastName, decimal balance)
        {
            this.OwnerFirstName = ownersFirstName;
            this.OwnerLastName = ownersLastName;
            this.Balance = balance;
            AccountOwner = OwnerFirstName + " " + OwnerLastName;
        }
            
    }
}
