using System;
using System.Threading.Tasks;
using WalletService.Model;

namespace WalletService
{
    public interface IWalletService
    {
        Task<Guid> Put(OperationDepositAndWithdrawal oper);
        Task<Wallet> State(Guid user);
        Task<Guid> Transfer(OperationTransferWithinAccount oper);
        Task<Guid> Withdraw(OperationDepositAndWithdrawal oper);
    }
}