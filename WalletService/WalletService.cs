using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletRepository;
using WalletService.Model;

namespace WalletService
{
    public class WalletService : IWalletService
    {
        private readonly WalletDbContext _walletDBContext;
        private readonly IMapper _mapper;

        public WalletService(WalletDbContext walletDBContext, IMapper mapper)
        {
            _walletDBContext = walletDBContext;
            _mapper = mapper;
        }

        public async Task<Guid> Put(OperationDepositAndWithdrawal oper)
        {
            var historyOperation = new Guid();
            //TODO finish transaction add cash
            await _walletDBContext.Wallet.AddAsync();
            await _walletDBContext.SaveChangesAsync();
            return historyOperation;

        }

        public async Task<Guid> Withdraw(OperationDepositAndWithdrawal oper)
        {
            var historyOperation = new Guid();
            //TODO finish transaction add cash
            await _walletDBContext.Wallet.AddAsync();
            await _walletDBContext.SaveChangesAsync();
            return historyOperation;
        }

        public async Task<Guid> Transfer(OperationTransferWithinAccount oper)
        {
            var historyOperation = new Guid();
            //TODO finish transaction add cash
            await _walletDBContext.Wallet.AddAsync();
            await _walletDBContext.SaveChangesAsync();
            return historyOperation;
        }

        public async Task<Wallet> State(Guid user)
        {
            var walletResult = new Wallet();
            walletResult.UserId = user;
            walletResult.cash = new Dictionary<string, decimal>();

            var wallet1 = _walletDBContext.Wallet.Where(w => w.UserId == user).ToList();
            var wallet = _walletDBContext.Wallet
                .Where(w => w.UserId == user)
                .Join(_walletDBContext.Currency, f => f.CurrencyId, s => s.Id, (f, s) => new
                {
                    Currency = s.Tiker,
                    Amount = f.Amount
                })
                .ToList();
                //.ToDictionary(k => k.Currency);

            foreach (var item in wallet)
            {
                walletResult.cash.Add(item.Currency, item.Amount);
            }

            return walletResult;
        }
    }
}
