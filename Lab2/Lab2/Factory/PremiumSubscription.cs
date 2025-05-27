using Lab_2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class PremiumSubscription : TotSubscription
    {
        public string Name => "Преміум підпис";
        public double MonthFee => 25.99;
        public int MinPeriod => 4;
        public List<string> Channels { get; } = new List<string> { "Netflix", "Sweet.tv", "MEGOGO" };

        public string GetSubscriptionInfo()
        {
            return $"{Name}: ${MonthFee}/місяць, {MinPeriod} місяці мінімальний період, Канали: {string.Join(", ", Channels)}";
        }
    }
}

