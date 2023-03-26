using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        public string Message { get; private set; }
    
        public decimal Sum { get; private set; }

        public AccountEventArgs(string _message, decimal _sum)
        {
            Message = _message;
            Sum = _sum;
        }
    }
}
