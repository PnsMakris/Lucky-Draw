using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_For_Teams_3rd
{
    class CommonNumber
    {
        // create frields
        public static List<int> most_common_List = new List<int>();
        public static int[] most_common_Array = new int[most_common_List.Count];
        public static List<int> most_common_Tzoker_List = new List<int>();
        public static int[] most_common_Tzoker_Array = new int[most_common_List.Count];

        // method to find the 3 most common and 3 less common numbers of our draws
        public static void MostCommonNumber()
        {
            int lenght = Draw.List_of_all_Five_Numbers.Count;
            for (int i = 0; i < lenght; i++)
            {
                int element = 0;
                var numbers = Draw.List_of_all_Five_Numbers.ToArray();
                int count = 0;
                if (numbers.Length != 0)
                {
                    for (int y = 0; y < numbers.Length; y++)
                    {
                        int tempElemnt = numbers[y];
                        int tempCount = 0;
                        for (int x = 0; x < numbers.Length; x++)
                        {
                            if (numbers[x] == tempElemnt)
                            {
                                tempCount++;
                            }
                        }
                        if (tempCount >= count)
                        {
                            element = tempElemnt;
                            count = tempCount;
                        }

                    }
                    most_common_List.Add(element);
                    Draw.List_of_all_Five_Numbers.RemoveAll(x => x == element);
                }


            }
        }

        // method to find the 3 most common and 3 less common lucky numbers of our draws
        public static void MostCommonLuckyNumber()
        {
            int lenght = Draw.List_of_all_LuckyNumbers.Count;
            for (int i = 0; i < lenght; i++)
            {
                int element = 0;
                var numbers = Draw.List_of_all_LuckyNumbers.ToArray();
                int count = 0;
                if (numbers.Length != 0)
                {
                    for (int y = 0; y < numbers.Length; y++)
                    {
                        int tempElemnt = numbers[y];
                        int tempCount = 0;
                        for (int x = 0; x < numbers.Length; x++)
                        {
                            if (numbers[x] == tempElemnt)
                            {
                                tempCount++;
                            }
                        }
                        if (tempCount >= count)
                        {
                            element = tempElemnt;
                            count = tempCount;
                        }

                    }
                    most_common_Tzoker_List.Add(element);
                    Draw.List_of_all_LuckyNumbers.RemoveAll(x => x == element);
                }
            }
        }
    }
}
