using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class GameVersion1
    {
        public static void LetsPlay()
        {
            // ask how many players want to join our game
            Console.Write("Give me number of players: ");
            int num_players = Convert.ToInt32(Console.ReadLine());

            // ask the number of DRAWS we're going to have
            Console.Write("Give me number of draws: ");
            int num_of_draws = Convert.ToInt32(Console.ReadLine());

            // use a loop to create PLAYERS and all of them are inside our playerList
            // each player have 5 random numbers and one random lucky number
            // and then print the result of each player
            var playerList = new List<Player>();
            for (int i = 1; i <= num_players; i++)
            {
                var playerNumbers = Player.RandomList(5, 1, 46);
                var luckyNumber = Player.RandomLuckyNumber();
                Player player = new Player(i)
                {
                    FiveNumbers = playerNumbers,
                    LuckyNumber = luckyNumber
                };

                Thread.Sleep(1000);
                playerList.Add(player);
                Console.WriteLine("User {0} numbers are: {1} - {2} - {3} - {4} - {5}", i, playerNumbers[0],
                    playerNumbers[1], playerNumbers[2], playerNumbers[3], playerNumbers[4]);
                Console.WriteLine("And lucky number is: {0}", luckyNumber);
            }
            Console.WriteLine("\n");

            // use a loop to create DRAWS and all of them are inside our drawList as did in players above
            // each draw have 5 random numbers and one random lucky number
            // and then print the result of each draw
            var drawList = new List<Draw>();
            for (int i = 1; i <= num_of_draws; i++)
            {
                var drawNumbers = Draw.DrawList(5, 1, 46);
                var drawLucky = Draw.DrawLuckyNumber();
                Draw draw = new Draw(i)
                {
                    FiveNumbers = drawNumbers,
                    LuckyNumber = drawLucky
                };

                Thread.Sleep(500);
                drawList.Add(draw);
                Console.WriteLine("Draw {0} numbers are: {1} - {2} - {3} - {4} - {5}", i, drawNumbers[0],
                    drawNumbers[1], drawNumbers[2], drawNumbers[3], drawNumbers[4]);
                Console.WriteLine("And Draw Lucky number is: {0}", drawLucky);

            }
            Console.WriteLine("\n");

            // assign a variable to call the static method with the starting budget of each Draw
            var startBudget = DrawBudget.addBudget(1000);

            // from RESULT class we use static method DrawChecking and as parameter
            // put the lists we create above and then we get the right result for each draw
            Result.DrawChecking(drawList, playerList);

            // use a static method from class CommonNumber to get the 3 most common and the 3 less common
            // numbers of our list of draws and print the results!!!
            CommonNumber.MostCommonNumber();
            CommonNumber.most_common_Array = CommonNumber.most_common_List.ToArray();
            Console.Write("Most Common Numbers are: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", CommonNumber.most_common_Array[i]);
            }
            Console.WriteLine("\n");
            Console.Write("Less Common Numbers are: ");
            for (int i = CommonNumber.most_common_Array.Length - 1; i > CommonNumber.most_common_Array.Length - 4; i--)
            {
                Console.Write("{0} ", CommonNumber.most_common_Array[i]);
            }
            Console.WriteLine("\n");

            // use a static method from class CommonNumber to get the 3 most common and the 3 less common
            // lucky numbers of our list of drawsand print the results!!!
            CommonNumber.MostCommonLuckyNumber();
            CommonNumber.most_common_Tzoker_Array = CommonNumber.most_common_Tzoker_List.ToArray();
            Console.Write("Most Common Lucky Numbers are: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", CommonNumber.most_common_Tzoker_Array[i]);
            }
            Console.WriteLine("\n");
            Console.Write("Less Common Lucky Numbers are: ");
            for (int i = CommonNumber.most_common_Tzoker_Array.Length - 1; i > CommonNumber.most_common_Tzoker_Array.Length - 4; i--)
            {
                Console.Write("{0} ", CommonNumber.most_common_Array[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
