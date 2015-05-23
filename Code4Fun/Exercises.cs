using System;
using System.Diagnostics;

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

    }
}