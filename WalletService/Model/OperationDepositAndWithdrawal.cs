using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletService.Model
{
    public class OperationDepositAndWithdrawal
    {
        public Guid User { get; set; }
        public string TikerCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
