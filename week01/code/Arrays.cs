public static class Arrays
{
    /// <summary>
    /// Makes an array (a row of numbers) with multiples of a number.
    /// Example: MultiplesOf(7, 5) → {7, 14, 21, 28, 35}.
    /// </summary>
    /// <returns>An array of numbers that are multiples of the base number</returns>
    public static double[] MultiplesOf(double baseNumber, int count)
    {
        // First I make an empty array that can hold "count" numbers
        double[] multiples = new double[count];

        // Then I go through each spot in the array
        for (int i = 0; i < count; i++)
        {
            // Put baseNumber * (i+1) in the current spot
            multiples[i] = baseNumber * (i + 1);
        }

        // Then give back the array 
        return multiples; 
    }

    /// <summary>
    /// This moves the numbers in the list to the right by "amount".
    /// Example: {1,2,3,4,5,6,7,8,9}, amount = 3 → {7,8,9,1,2,3,4,5,6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // If the list is empty, or the amount is not valid
        if (data == null || data.Count == 0 || amount < 1 || amount > data.Count)
        {
            return;
        }

        // If moving by the sizee of the list, then nothing changes
        if (amount % data.Count == 0)
        {
            return;
        }

        // Figure out howe many spaces need to move
        int rotation = amount % data.Count;

        // Split the list into two parts:
        // 1) the last "rotation" numbers
        // 2) the rest of the numbers
        List<int> lastPart = data.GetRange(data.Count - rotation, rotation);
        List<int> firstPart = data.GetRange(0, data.Count - rotation);

        // Clear the list, then put the two parts back in the new order
        data.Clear();
        data.AddRange(lastPart);   // last part goes first
        data.AddRange(firstPart);  // then the first part goes after that
    }
}
