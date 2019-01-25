using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class Draw
    {
        // create properties
        public List<int> FiveNumbers { get; set; }
        public int LuckyNumber { get; set; }
        public int ID { get; set; }
        public static List<int> List_of_all_Five_Numbers = new List<int>();
        public static List<int> List_of_all_LuckyNumbers = new List<int>();

        // create constructor
        public Draw(int id)
        {
            ID = id;
        }

        // create a method to get the random DRAW numbers
        public static List<int> DrawList(int listLength, int minValue, int maxValue)
        {
            int number = 0;
            int counter = 0;

            List<int> NumberList = new List<int>();

            while (counter < listLength)
            {
                Random random = new Random();
                number = random.Next(minValue, maxValue);
                if (!NumberList.Contains(number))
                {
                    NumberList.Add(number);
                    counter = ++counter;
                    List_of_all_Five_Numbers.Add(number);
                }
                else
                {
                    continue;
                }
            }
            return NumberList;
        }

        // method to get a random number for DRAW results
        public static int DrawLuckyNumber()
        {
            var rand = new Random();
            var draw_Lucky_Number = rand.Next(1, 21);
            List_of_all_LuckyNumbers.Add(draw_Lucky_Number);
            return draw_Lucky_Number;
        }

    }
}
