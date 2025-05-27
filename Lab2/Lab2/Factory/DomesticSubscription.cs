using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Factory
{
    public class DomesticSubscription : TotSubscription
    {
        public string Name => "Домашній підпис";
        public double MonthFee => 15.99;
        public int MinPeriod => 1;
        public List<string> Channels { get; } = new List<string> { "Єдині новини", "Теле-шоу", "Спорт" };

        public string GetSubscriptionInfo()
        {
            return $"{Name}: ${MonthFee}/місяць, {MinPeriod} місяці мінімальний період, Канали: {string.Join(", ", Channels)}";
        }
    }

}
