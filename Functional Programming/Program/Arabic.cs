using System.Collections.Generic;

namespace RomanNuerals
{
    public class Arabic
    {
        private readonly int _number;

        public Arabic(int number)
        {
            _number = number;
        }

        public string ToRoman()
        {
            // int temp = _number; // mutable state
            // string roman = ""; // mutable state

            // foreach (var entry in GetNumerals())
            // {
            //     while (temp >= entry.Value)
            //     {
            //         roman = roman + entry.Key;
            //         temp -= entry.Value;
            //     }
            // }

            // return roman;
            return FuncToRoman();
        }

        public string FuncToRoman()
        {
            return FuncToRoman("", _number, 0);
        }

        public string FuncToRoman(string roman, int curr_val, int romanIndex)
        {
            if (curr_val == 0) // Base case
            {
                return roman;
            }
            else
            {
                var entry = GetNumerals()[romanIndex];
                if (curr_val >= entry.Value)
                {
                    return FuncToRoman(roman + entry.Key, curr_val - entry.Value, romanIndex);
                }
                return FuncToRoman(roman, curr_val, romanIndex + 1);
            }
        }

        public List<KeyValuePair<string, int>> GetNumerals()
        {
            return new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("M", 1000),
                new KeyValuePair<string, int>("CM", 900),
                new KeyValuePair<string, int>("D", 500),
                new KeyValuePair<string, int>("CD", 400),
                new KeyValuePair<string, int>("C", 100),
                new KeyValuePair<string, int>("XC", 90),
                new KeyValuePair<string, int>("L", 50),
                new KeyValuePair<string, int>("XL", 40),
                new KeyValuePair<string, int>("X", 10),
                new KeyValuePair<string, int>("IX", 9),
                new KeyValuePair<string, int>("V", 5),
                new KeyValuePair<string, int>("IV", 4),
                new KeyValuePair<string, int>("I", 1)
            };
        }
    }


}


