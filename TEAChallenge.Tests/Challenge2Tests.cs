using TEAChallenge.Challenges;

namespace TEAChallenge.Tests;

public class Challenge2Tests
{
    [Theory]
    [InlineData("gbcjbdha", 7)] // b -> j = 7
    [InlineData("thequickbrownfoxjumpsoverthelazydog", 24)] // a -> z = 24
    [InlineData("za", 0)] // z doesn't come before a
    public void TestMaxDistance(string input, int expectedValue)
    {
        var challenge2 = new Challenge2();

        Assert.Equal(expectedValue, challenge2.MaxDistance(input));
    }
}