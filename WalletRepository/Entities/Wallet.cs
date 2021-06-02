using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletRepository.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}
