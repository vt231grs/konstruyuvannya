using Lab_2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class EducationalSubscription : TotSubscription
    {
        public string Name => "Освітній підпис";
        public double MonthFee => 10.99;
        public int MinPeriod => 2;
        public List<string> Channels { get; } = new List<string> { "Легенди Ломбарду", "Між молотом та наковальнею", "Руйнівники міфів" };

        public string GetSubscriptionInfo()
        {
            return $"{Name}: ${MonthFee}/місяць, {MinPeriod} місяці мінімальний період, Канали: {string.Join(", ", Channels)}";
        }
    }
}
