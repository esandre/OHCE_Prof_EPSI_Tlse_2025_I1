using OHCE_Prof;
using OHCE_Prof.Langue;

namespace OHCE.Test.Utilities;

internal class DétecteurPalindromeBuilder
{
    private ILangue _langue = new LangueStub();

    public static DétecteurPalindrome Default() 
        => new DétecteurPalindromeBuilder().Build();

    public DétecteurPalindromeBuilder AyantPourLangue(ILangue langue)
    {
        _langue = langue;
        return this;
    }

    public DétecteurPalindrome Build()
    {
        return new DétecteurPalindrome(_langue);
    }
}