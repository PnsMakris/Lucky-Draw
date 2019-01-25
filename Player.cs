using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class Player
    {
        // create properties
        public List<int> FiveNumbers { get; set; }
        public int LuckyNumber { get; set; }
        public int ID { get; set; }

        // create constructor
        public Player(int id)
        {
            ID = id;
        }

        // method to get random numbers in a list for each player when i use it
        public static List<int> RandomList(int listLength, int minValue, int maxValue)
        {
            int number = 0;
            int counter = 0;

            List<int> NumberList = new List<int>();

            while (counter < listLength)
            {
                Random random = new Random();
                number = random.Next(minValue, maxValue);
                if (NumberList.Contains(number))
                {
                    continue;
                }
                else
                {
                    NumberList.Add(number);
                    counter++;
                }
            }
            return NumberList;
        }

        // method to get random int number
        public static int RandomLuckyNumber()
        {
            var rand = new Random();
            var random_Lucky_Number = rand.Next(1, 21);
            return random_Lucky_Number;
        }

    }
}
