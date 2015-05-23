using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Code4Fun.Exercises
{
    public class ShuffleArray
    {
        public int[] GetShuffleArray(int length)
        {
            try
            {
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr.SetValue(i + 1, i);
                }

                int arrayLength = arr.Length;
                while (arrayLength > 1)
                {
                    arrayLength--;
                    int k = new Random().Next(arrayLength + 1);
                    int value = arr[k];
                    arr[k] = arr[arrayLength];
                    arr[arrayLength] = value;
                }  

                return arr;
            }

            catch (System.OutOfMemoryException ex)
            {
                
                Trace.WriteLine("The array is oversized, I can't create it");
                return new int[0];
            }            
        }
    }

    public class PhoneKeypad
    {
        private Dictionary<char, string> translation = new Dictionary<char, string>()
        {
            {'a', "2"},
            {'b', "22"},
            {'c', "222"},
            {'d', "3"},
            {'e', "33"},
            {'f', "333"},
            {'g', "4"},
            {'h', "44"},
            {'i', "444"},
            {'j', "5"},
            {'k', "55"},
            {'l', "555"},
            {'m', "6"},
            {'n', "66"},
            {'o', "666"},
            {'p', "7"},
            {'q', "77"},
            {'r', "777"},
            {'s', "7777"},
            {'t', "8"},
            {'u', "88"},
            {'v', "888"},
            {'w', "9"},
            {'x', "99"},
            {'y', "999"},
            {'z', "9999"},
            {' ', "0"},
        };
        public string GetTheEncodedString(string input)
        {
            char[] inputArray = input.ToCharArray();
            string tempValue;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (translation.TryGetValue(inputArray[i], out tempValue))
                {
                    if (i > 0 && inputArray[i] == inputArray[i - 1])
                    {
                        output.Append("_");
                    }

                    output.Append(tempValue);
                }

                else
                {
                    output.Clear();
                    output.AppendLine("Error, one or more characters not allowed");
                    break;
                }
            }

            return output.ToString();
        }
    }
}