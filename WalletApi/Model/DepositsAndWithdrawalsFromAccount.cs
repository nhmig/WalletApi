using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletApi.Model
{
    public class DepositsAndWithdrawalsFromAccount
    {
        public Guid User { get; set; }
        public string TikerCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
