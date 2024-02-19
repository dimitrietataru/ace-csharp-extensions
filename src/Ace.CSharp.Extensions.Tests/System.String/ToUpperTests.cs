namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUpperTests
{
    [Fact]
    internal void GivenToUpperLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string @this = "the quick brown fox jumps over the lazy dog";
        string expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToUpperLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal void GivenToUpperLocalWhenSideEffectMayOccurThenResultIsUnpredictable()
    {
        // Arrange
        string @this = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToUpperLocal();
        string unexpected = @this.ToUpper(CultureFactory.GetByName(Cultures.TrTR));

        // Assert
        actual.Should().NotBeEquivalentTo(unexpected);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUpperLocalWhenValueIsNotValidThenReturnsValue(string @this)
    {
        // Arrange

        // Act
        string actual = @this.ToUpperLocal();

        // Assert
        actual.Should().BeSameAs(@this);
    }

    [Fact]
    internal void GivenToUpperOrDefaultLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string @this = "the quick brown fox jumps over the lazy dog";
        string expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToUpperOrDefaultLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUpperOrDefaultLocalWhenValueIsNotValidThenReturnsFallbackValue(string? @this)
    {
        // Arrange
        string fallbackValue = "foo";

        // Act
        string actual = @this.ToUpperOrDefaultLocal(fallbackValue);

        // Assert
        actual.Should().Be(fallbackValue);
    }
}
