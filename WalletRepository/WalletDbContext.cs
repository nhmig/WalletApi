using Microsoft.EntityFrameworkCore;
using WalletRepository.Entities;

namespace WalletRepository
{
    public class WalletDbContext : DbContext
    {
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Currency> Currency { get; set; }

        public DbSet<Operation> Operation { get; set; }
        public DbSet<HistoryOperation> HistoryOperation { get; set; }

        public WalletDbContext()
        {

        }
    }
}
