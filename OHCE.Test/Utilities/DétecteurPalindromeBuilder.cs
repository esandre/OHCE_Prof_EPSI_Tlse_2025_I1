using OHCE_Prof;

namespace OHCE.Test.Utilities;

internal class DétecteurPalindromeBuilder
{
    public static DétecteurPalindrome Default() => new DétecteurPalindromeBuilder().Build();

    public DétecteurPalindrome Build()
    {
        return new DétecteurPalindrome(new LangueParDéfaut());
    }
}