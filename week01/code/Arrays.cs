public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // MY Plan:
        // Step 1: I Create a new array of doubles with the size equal to 'length'.
        // Step 2: I Loop through the array using a for loop from index 0 to length - 1.
        // Step 3: For each index i, calculate the multiple using number * (i + 1).
        // Step 4: I Store the calculated value in the array at index i.
        // Step 5: After the loop finishes, return the array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // my Plan:
        // Step 1: I Find the split position.
        // Step 2: I Copy the last 'amount' items.
        // Step 3: I Remove them from the original list.
        // Step 4: I Insert them at the beginning.

        int split = data.Count - amount;

        List<int> temp = data.GetRange(split, amount);

        data.RemoveRange(split, amount);

        data.InsertRange(0, temp);
    }
}
