using System;

namespace KursyWalut
{

    public class ExchangeRate
    {
        public string rateBase { get; set; }

        public string rateTarget { get; set; }

        public DateTime date { get; set; }

        public float value { get; set; }
    }
}
