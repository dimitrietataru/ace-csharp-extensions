namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUpperOrDefaultLocalTests
{
    [Fact]
    internal void GivenToUpperOrDefaultLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "the quick brown fox jumps over the lazy dog";
        string expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToUpperOrDefaultLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUpperOrDefaultLocalWhenValueIsNotValidThenReturnsFallbackValue(string input)
    {
        // Arrange
        string fallbackValue = "foo";

        // Act
        string actual = input.ToUpperOrDefaultLocal(fallbackValue);

        // Assert
        actual.Should().Be(fallbackValue);
    }
}
