namespace TEAChallenge.Challenges;

public class Challenge2
{
    /// <summary>
    /// Return the maximum distance for a pair of letters in the string input.
    /// The maximum distance is defined as the largest difference between any input[i] and input[j]
    /// where i &lt; j and input[i] comes before input[j] in the alphabet.
    /// This works by comparing numeric char values and will not work for non lowercase letters.
    /// </summary>
    /// <param name="input">The string to calculate the max distance from.</param>
    /// <returns>The maximum distance between the two qualifying characters.</returns>
    public int MaxDistance(string input)
    {
        var maxDistance = 0;

        for (var i = 0; i < input.Length - 1; i++)
        {
            for (var j = i + 1; j < input.Length; j++)
            {
                if (input[i] >= input[j] || input[j] - input[i] - 1 <= maxDistance)
                {
                    continue;
                }
                
                maxDistance = input[j] - input[i] - 1;
            }
        }

        return maxDistance;
    }
}