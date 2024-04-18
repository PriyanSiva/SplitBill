using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBillClassLibrary
{
        public class Splitter
        {
            public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
            {
                if (numberOfPeople <= 0)
                    throw new ArgumentException("Number of people must be greater than 0.");

                return totalAmount / numberOfPeople;
            }
        }
   
}
