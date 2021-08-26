using KursyWalut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Repositories
{
    public class ExchangeRateRepository : IExchangeRateRepository
    {
        private readonly ExchangeRateContext _context;

        public ExchangeRateRepository(ExchangeRateContext context)
        {
            _context = context;
        }
           
        public async Task<IEnumerable<ExchangeRate>> Get(string rateBase, string rateTarget, DateTime startDate, DateTime endDate)
        {
            List<ExchangeRate> list = (List<ExchangeRate>)(IEnumerable<ExchangeRate>)await _context.ExchangeRates.FindAsync(rateBase, rateTarget);
            return list;
        }
    }
}
