using OHCE_Prof.Langue;

namespace OHCE_Prof;

public class DétecteurPalindrome
{
    private readonly string _félicitations;

    public DétecteurPalindrome(ILangue langue)
    {
        _félicitations = langue.Féliciter();
    }

    public string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return Expressions.Salutations + Environment.NewLine + miroir + Environment.NewLine + _félicitations + Environment.NewLine + Expressions.Acquittance;
        return Expressions.Salutations + Environment.NewLine + miroir + Environment.NewLine + Expressions.Acquittance;
    }
}