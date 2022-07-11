namespace Ace.CSharp.Extensions.Tests;

internal static class CultureFactory
{
    public static CultureInfo GetByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Culture name must be specified", nameof(name));
        }

        return new CultureInfo(name);
    }
}

internal static class Cultures
{
    public const string RoRO = "ro-RO";
    public const string EnUS = "en-US";
    public const string EnGB = "en-GB";
    public const string TrTR = "tr-TR";
}
