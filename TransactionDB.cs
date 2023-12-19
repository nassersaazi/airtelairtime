using Microsoft.EntityFrameworkCore;

class TransactionDB : DbContext
{
    public TransactionDB(DbContextOptions<TransactionDB> options)
        : base(options) { }

    public DbSet<Transaction> Transactions => Set<Transaction>();
}