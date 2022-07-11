namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUpperOrEmptyLocalTests
{
    [Fact]
    internal void GivenToUpperOrEmptyLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "the quick brown fox jumps over the lazy dog";
        string expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToUpperOrEmptyLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUpperOrEmptyLocalWhenValueIsNotValidThenReturnsFallbackValue(string input)
    {
        // Arrange

        // Act
        string actual = input.ToUpperOrEmptyLocal();

        // Assert
        actual.Should().BeEmpty();
    }
}
