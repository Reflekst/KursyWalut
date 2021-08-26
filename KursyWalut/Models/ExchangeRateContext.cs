using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Models
{
    public class ExchangeRateContext : DbContext
    {

        public ExchangeRateContext(DbContextOptions<ExchangeRateContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
    }
}
