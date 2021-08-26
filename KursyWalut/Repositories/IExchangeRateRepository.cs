using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Repositories
{
    interface IExchangeRateRepository
    {
        Task<IEnumerable<ExchangeRate>> Get(string rateBase, string rateTarget, DateTime startDate, DateTime endDate);
    }
}
