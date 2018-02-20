using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }



        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfDecorations() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }

        private decimal CalculateCostOfBeveragePerPerson()
        {
            decimal costOfBeveragePerPerson;
            if (HealthyOption)
            {
                costOfBeveragePerPerson = 5.00M;
            }
            else
            {
                costOfBeveragePerPerson = 20.00M;
            }
            return costOfBeveragePerPerson;
        }

    }
}
