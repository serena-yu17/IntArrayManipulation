using System.Collections.Generic;

namespace IntArrayManipulation.Operations
{
    /// <summary>
    /// Handles manipulation on int arrays
    /// </summary>
    public static class ArrayManipService
    {
        /// <summary>
        /// Swap two values in an array in-place
        /// </summary>
        /// <param name="inputValues">The supplied array</param>
        /// <param name="index1">The first index to be swapped</param>
        /// <param name="index2">The second index to be swapped</param>
        static void Swap(this int[] inputValues, int index1, int index2)
        {
            if (inputValues == null || index1 >= inputValues.Length || index2 >= inputValues.Length)
                return;
            var temp = inputValues[index1];
            inputValues[index1] = inputValues[index2];
            inputValues[index2] = temp;
        }

        /// <summary>
        /// To reverse an int array in place. The original Span will be modified. 
        /// If the parameter is null, it will return null.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the Span</typeparam>
        /// <param name="inputValues">The input values</param>
        /// Time complexity O(n), space complexity O(1)
        public static void Reverse(int[] inputValues)
        {
            //On null or empty, do nothing
            if (inputValues == null || inputValues.Length < 2)
            {
                return;
            }
            //swap values from aymmertrical indexes
            int left = 0;
            int right = inputValues.Length - 1;
            while (left < right)
            {
                inputValues.Swap(left, right);
                left++;
                right--;
            }
        }

        /// <summary>
        /// Removes an element at the index chosen. The original Span will be modified. 
        /// If the parameter is null, it will return null.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the Span</typeparam>
        /// <param name="inputValues">The input values</param>
        /// <param name="removeIndex">The index to be removed at</param>
        /// <returns>The Span that has an element removed</returns>
        /// Time Complexity O(n), space complexity O(n)
        public static int[] DeletePart(int[] inputValues, int removeIndex)
        {
            //return the original array if input is invalid
            if (inputValues == null || removeIndex >= inputValues.Length)
            {
                return inputValues;
            }

            //construct a new List ignoring the removeIndex
            List<int> prepared = new List<int>();
            for (int idx = 0; idx < inputValues.Length; idx++)
            {
                if (idx != removeIndex)
                {
                    prepared.Add(inputValues[idx]);
                }
            }
            return prepared.ToArray();
        }
    }
}
