using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursyWalut.Models
{
    public class IncomeExRate
    {
        public string Table { get; set; }

        public string Currcency { get; set; }

        public string Base { get; set; }

        public List<Rate> rates { get; set; }

    }
    public class Rate
    {
        public string No { get; set; }

        public string EffectiveDate { get; set; }

        public float Mid { get; set; }
    }
}
