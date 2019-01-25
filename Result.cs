using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class Result
    {
        // create fields
        public static int fivePlus1;
        public static int fivePlus0;
        public static int fourPlus1;
        public static int fourPlus0;
        public static int threePlus1;
        public static int threePlus0;
        public static int twoPlus1;
        public static int twoPlus0;
        public static int onePlus1;
        public static int onePlus0;

        // method to check the list of each player numbers with the DRAW numbers
        public static void CheckResults(List<Player> players, int draw_LuckyNumber, List<int> draw_Results)
        {
            foreach (Player player in players)
            {
                int counter_For_Five_Numbers = 0;
                int counter_For_Lucky_Number = 0;
                foreach (int num in player.FiveNumbers)
                {
                    if (draw_Results.Contains(num))
                    {
                        counter_For_Five_Numbers++;
                    }
                }
                if (player.LuckyNumber == draw_LuckyNumber)
                {
                    counter_For_Lucky_Number++;
                }
                switch (counter_For_Five_Numbers)
                {
                    case 5:
                        if (counter_For_Lucky_Number == 1)
                        {
                            fivePlus1++;
                        }
                        else fivePlus0++;
                        break;
                    case 4:
                        if (counter_For_Lucky_Number == 1)
                        {
                            fourPlus1++;
                        }
                        else fourPlus0++;
                        break;
                    case 3:
                        if (counter_For_Lucky_Number == 1)
                        {
                            threePlus1++;
                        }
                        else threePlus0++;
                        break;
                    case 2:
                        if (counter_For_Lucky_Number == 1)
                        {
                            twoPlus1++;
                        }
                        else twoPlus0++;
                        break;
                    case 1:
                        if (counter_For_Lucky_Number == 1)
                        {
                            onePlus1++;
                        }
                        else onePlus0++;
                        break;
                }
            }

        }

        // method to get zero value on my fields
        public static void AssignZeroAtFields()
        {
            fivePlus1 = 0;
            fivePlus0 = 0;
            fourPlus1 = 0;
            fourPlus0 = 0;
            threePlus1 = 0;
            threePlus0 = 0;
            twoPlus1 = 0;
            twoPlus0 = 0;
            onePlus1 = 0;
            onePlus0 = 0;
        }

        // method to get the results for each category
        public static void PrintMyResults()
        {
            Console.WriteLine("result 5 + 1 : {0}", fivePlus1);
            Console.WriteLine("result 5 + 0 : {0}", fivePlus0);
            Console.WriteLine("result 4 + 1 : {0}", fourPlus1);
            Console.WriteLine("result 4 + 0 : {0}", fourPlus0);
            Console.WriteLine("result 3 + 1 : {0}", threePlus1);
            Console.WriteLine("result 3 + 0 : {0}", threePlus0);
            Console.WriteLine("result 2 + 1 : {0}", twoPlus1);
            Console.WriteLine("result 2 + 0 : {0}", twoPlus0);
            Console.WriteLine("result 1 + 1 : {0}", onePlus1);
            Console.WriteLine("result 1 + 0 : {0}", onePlus0);
        }

        // method to check for every list of draws if there are same numbers with the list of number of eatch player
        public static void DrawChecking(List<Draw> randomDraws, List<Player> player)
        {
            foreach (Draw draw in randomDraws)
            {
                // every time i call this method my fields start over zero value
                AssignZeroAtFields();

                // method to CHECK if each player's list has same numbers with each draw
                CheckResults(player, draw.LuckyNumber, draw.FiveNumbers);

                // print the DRAW numbers
                Console.Write("Draw numbers are: ");
                foreach (int num in draw.FiveNumbers)
                {
                    Console.Write($"{num}.");
                }
                Console.WriteLine(" And The Lucky Number is : " + draw.LuckyNumber);

                // print the result for each loop
                PrintMyResults();

                // call from DrawBudget class a method to get the money every player won in each Draw
                DrawBudget.WinnerMoney(DrawBudget.budget);
            }
            Console.WriteLine("\n");
        }
    }
}
