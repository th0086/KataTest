using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KataTest.Kata_No._1_String_average
{
    public class Kata1
    {
        private static Dictionary<string, int> _dicNumber = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };

        public static string AverageString(string str)
        {
            if (!string.IsNullOrEmpty(str) && Regex.IsMatch(str, "[A-Za-z0-9\u4e00-\u9fa5-]+"))
            {
                return GetStringAverage(GetStringList(str));
            }
            return "n/a";
        }

        public static string GetStringAverage(List<int> list)
        {
            if (_dicNumber.ContainsValue((int)list.Average()))
            {
                return _dicNumber.FirstOrDefault(x => x.Value.Equals((int)list.Average())).Key;
            }
            return "n/a";
        }

        public static List<int> GetStringList(string str)
        {
            string[] List_str = str.Split(' ');

            var list = new List<int>();

            foreach (var s in List_str)
            {
                list.Add(_dicNumber[s]);
            }

            return list;
        }
    }
}