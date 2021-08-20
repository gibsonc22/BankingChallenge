using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgChallenge
{
    class SavingsAcct : CheckingAcct
    {
        
        private decimal _interest = 0.025m;
        private int _count = 0;

        public SavingsAcct(string OwnerFirstName, string OwnerSecondName, decimal Interest, decimal Balance) : base(OwnerFirstName, OwnerSecondName, Balance)
        {
            
        }

        public void ApplyInterest()
        {
            Balance *= 1 + _interest;
        }

        public new void Withdraw(decimal amount)
        {
            _count++;
        }

      

    }
}
