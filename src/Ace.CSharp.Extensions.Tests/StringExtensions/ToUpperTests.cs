namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUpperTests
{
    [Fact]
    internal void GivenToUpperLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string input = "the quick brown fox jumps over the lazy dog";
        string expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToUpperLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal void GivenToUpperLocalWhenSideEffectMayOccurThenResultIsUnpredictable()
    {
        // Arrange
        string input = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = input.ToUpperLocal();
        string unexpected = input.ToUpper(CultureFactory.GetByName(Cultures.TrTR));

        // Assert
        actual.Should().NotBeEquivalentTo(unexpected);
    }

    [Theory]
    [InlineData(null!)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUpperLocalWhenValueIsNotValidThenReturnsValue(string input)
    {
        // Arrange

        // Act
        string actual = input.ToUpperLocal();

        // Assert
        actual.Should().BeSameAs(input);
    }

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
