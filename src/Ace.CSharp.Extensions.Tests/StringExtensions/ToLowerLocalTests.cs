namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToLowerLocalTests
{
    [Fact]
    internal void GivenToLowerLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        string expected = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToLowerLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal void GivenToLowerLocalWhenSideEffectMayOccurThenResultIsUnpredictable()
    {
        // Arrange
        string input = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToLowerLocal();
        string unexpected = input.ToLower(CultureFactory.GetByName(Cultures.TrTR));

        // Assert
        actual.Should().NotBeEquivalentTo(unexpected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToLowerLocalWhenValueIsNotValidThenReturnsValue(string input)
    {
        // Arrange

        // Act
        string actual = input.ToLowerLocal();

        // Assert
        actual.Should().BeSameAs(input);
    }
}
