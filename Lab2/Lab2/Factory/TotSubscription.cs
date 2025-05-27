using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Factory
{
    public interface TotSubscription
    {
        string Name { get; }
        double MonthFee { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }

        string GetSubscriptionInfo();
    }
}