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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Create an array with size equal to 'length'
        // Step 2: Loop from 0 to length - 1
        // Step 3: At each index, calculate (number * (i + 1))
        // Step 4: Store result in the array
        // Step 5: Return the completed array

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Find split point (where rotation starts)
        // Step 2: Take last 'amount' elements
        // Step 3: Shift first part to the right
        // Step 4: Rebuild list in rotated order
         int n = data.Count;

        // Get the last 'amount' elements
        List<int> rightPart = data.GetRange(n - amount, amount);

        // Get the first part of the list
        List<int> leftPart = data.GetRange(0, n - amount);

        // Clear original list
        data.Clear();

        // Rebuild in rotated order
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
