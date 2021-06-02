using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletService.Model
{
    public class Wallet
    {
        public Guid UserId { get; set; }
        public Dictionary<string, decimal> cash { get; set; }
    }
}
