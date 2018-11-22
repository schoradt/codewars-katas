using System;

namespace LibKatas
{
    public class StringKatas
    {
        public string HighAndLow(string input) {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            string[] stringNumbers = input.Split(' ');

            foreach(string stringNumber in stringNumbers) {
                int number = Int32.Parse(stringNumber);

                if (number < min) {
                    min = number;
                }

                if (number > max) {
                    max = number;
                }
            }

            return "" + max + " " + min;
        }
    }
}
