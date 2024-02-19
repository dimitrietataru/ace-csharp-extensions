namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToLowerTests
{
    [Fact]
    internal void GivenToLowerLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string @this = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        string expected = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToLowerLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    internal void GivenToLowerLocalWhenSideEffectMayOccurThenResultIsUnpredictable()
    {
        // Arrange
        string @this = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToLowerLocal();
        string unexpected = @this.ToLower(CultureFactory.GetByName(Cultures.TrTR));

        // Assert
        actual.Should().NotBeEquivalentTo(unexpected);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToLowerLocalWhenValueIsNotValidThenReturnsValue(string @this)
    {
        // Arrange

        // Act
        string actual = @this.ToLowerLocal();

        // Assert
        actual.Should().BeSameAs(@this);
    }

    [Fact]
    internal void GivenToLowerOrDefaultLocalWhenNoSideEffectOccursThenResultIsExpected()
    {
        // Arrange
        string @this = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
        string expected = "the quick brown fox jumps over the lazy dog";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.EnUS);
        string actual = @this.ToLowerOrDefaultLocal();

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToLowerOrDefaultLocalWhenValueIsNotValidThenReturnsFallbackValue(string? @this)
    {
        // Arrange
        string fallbackValue = "foo";

        // Act
        string actual = @this.ToLowerOrDefaultLocal(fallbackValue);

        // Assert
        actual.Should().Be(fallbackValue);
    }
}
