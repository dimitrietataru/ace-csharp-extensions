namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToLowerOrEmptyLocalTests
{
    [Fact]
    internal void GivenToLowerOrEmptyLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        string expected = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToLowerOrEmptyLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToLowerOrEmptyLocalWhenValueIsNotValidThenReturnsFallbackValue(string input)
    {
        // Arrange

        // Act
        string actual = input.ToLowerOrEmptyLocal();

        // Assert
        actual.Should().BeEmpty();
    }
}
