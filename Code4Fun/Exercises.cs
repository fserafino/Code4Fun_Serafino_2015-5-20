using System;

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
                return arr;
            }

            catch (System.OutOfMemoryException ex)
            {
                Console.WriteLine("The array is oversized, I can't create it");
                return new int[0];
            }            
        }
    }
}