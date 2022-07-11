namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToLowerOrDefaultLocalTests
{
    [Fact]
    internal void GivenToLowerOrDefaultLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        string expected = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToLowerOrDefaultLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToLowerOrDefaultLocalWhenValueIsNotValidThenReturnsFallbackValue(string input)
    {
        // Arrange
        string fallbackValue = "foo";

        // Act
        string actual = input.ToLowerOrDefaultLocal(fallbackValue);

        // Assert
        actual.Should().Be(fallbackValue);
    }
}
