using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class DrawBudget
    {
        //create fields
        public double fiveplus1;
        public double fiveplus0;
        public double fourplus1;
        public double fourplus0;
        public double threeplus1;
        public double threeplus0;
        public double twoplus1;
        public double twoplus0;
        public double oneplus1;
        public static double budget;

        // method to set the starting Budget
        public static double addBudget(double newBudget)
        {
            budget = newBudget;
            return budget;
        }

        // method for the money each category wins and the calculation of the budget 
        public static double WinnerMoney(double newBudget)
        {
            var moneyPerRound = new DrawBudget();
            var budgetForNext = newBudget;

            if (Result.fivePlus1 != 0)
            {
                moneyPerRound.fiveplus1 = (budget * 0.4) / Result.fivePlus1;
                budgetForNext -= moneyPerRound.fiveplus1 * Result.fivePlus1;
                Console.WriteLine("Money earned for 5+1: {0}", moneyPerRound.fiveplus1);
            }
            if (Result.fivePlus0 != 0)
            {
                moneyPerRound.fiveplus0 = (budget * 0.25) / Result.fivePlus0;
                budgetForNext -= moneyPerRound.fiveplus0 * Result.fivePlus0;
                Console.WriteLine("Money earned for 5+0: {0}", moneyPerRound.fiveplus0);
            }
            if (Result.fourPlus1 != 0)
            {
                moneyPerRound.fourplus1 = (budget * 0.15) / Result.fourPlus1;
                budgetForNext -= moneyPerRound.fourplus1 * Result.fourPlus1;
                Console.WriteLine("Money earned for 4+1: {0}", moneyPerRound.fourplus1);
            }
            if (Result.fourPlus0 != 0)
            {
                moneyPerRound.fourplus0 = (budget * 0.05) / Result.fourPlus0;
                budgetForNext -= moneyPerRound.fourplus0 * Result.fourPlus0;
                Console.WriteLine("Money earned for 4+0: {0}", moneyPerRound.fourplus0);
            }
            if (Result.threePlus1 != 0)
            {
                moneyPerRound.threeplus1 = (budget * 0.05) / Result.threePlus1;
                budgetForNext -= moneyPerRound.threeplus1 * Result.threePlus1;
                Console.WriteLine("Money earned for 3+1: {0}", moneyPerRound.threeplus1);
            }
            if (Result.threePlus0 != 0)
            {
                moneyPerRound.threeplus0 = (budget * 0.04) / Result.threePlus0;
                budgetForNext -= moneyPerRound.threeplus0 * Result.threePlus0;
                Console.WriteLine("Money earned for 3+0: {0}", moneyPerRound.threeplus0);
            }
            if (Result.twoPlus1 != 0)
            {
                moneyPerRound.twoplus1 = (budget * 0.035) / Result.twoPlus1;
                budgetForNext -= moneyPerRound.twoplus1 * Result.twoPlus1;
                Console.WriteLine("Money earned for 2+1: {0}", moneyPerRound.twoplus1);
            }
            if (Result.twoPlus0 != 0)
            {
                moneyPerRound.twoplus0 = (budget * 0.015) / Result.twoPlus0;
                budgetForNext -= moneyPerRound.twoplus0 * Result.twoPlus0;
                Console.WriteLine("Money earned for 2+0: {0}", moneyPerRound.twoplus0);
            }
            if (Result.onePlus1 != 0)
            {
                moneyPerRound.oneplus1 = (budget * 0.01) / Result.onePlus1;
                budgetForNext -= moneyPerRound.oneplus1 * Result.onePlus1;
                Console.WriteLine("Money earned for 1+1: {0}", moneyPerRound.oneplus1);
            }

            return budget = addBudget(1000) + budgetForNext;

        }
    }
}
