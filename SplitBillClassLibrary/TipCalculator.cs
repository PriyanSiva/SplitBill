using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBillClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace YourLibraryName
    {
        public class TipCalculator
        {
            public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
            {
                return mealCosts
                    .Select(entry => new KeyValuePair<string, decimal>(entry.Key, entry.Value * (decimal)(tipPercentage / 100)))
                    .ToDictionary(pair => pair.Key, pair => pair.Value);
            }

            public decimal TipPerPerson(decimal totalPrice, int numberOfPeople, float tipPercentage)
            {
                if (numberOfPeople == 0)
                    throw new ArgumentException("Number of people must be greater than 0.");

                decimal tipAmount = totalPrice * (decimal)(tipPercentage / 100);
                return tipAmount / numberOfPeople;
            }
        }
    }

}
