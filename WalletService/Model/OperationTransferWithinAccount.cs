using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletService.Model
{
    public class OperationTransferWithinAccount
    {
        public Guid User { get; set; }
        public string FromTikerCurrency { get; set; }
        public string ToTikerCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
