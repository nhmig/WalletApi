using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletRepository.Entities
{
    public class HistoryOperation
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OperationId { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}
