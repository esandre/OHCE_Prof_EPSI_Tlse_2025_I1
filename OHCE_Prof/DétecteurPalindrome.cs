using OHCE_Prof.Langue;

namespace OHCE_Prof;

public class DétecteurPalindrome
{
    private readonly string _félicitations;
    private readonly string _salutations;

    public DétecteurPalindrome(ILangue langue)
    {
        _félicitations = langue.Féliciter();
        _salutations = langue.Saluer();
    }

    public string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return _salutations + Environment.NewLine + miroir + Environment.NewLine + _félicitations + Environment.NewLine + Expressions.Acquittance;
        return _salutations + Environment.NewLine + miroir + Environment.NewLine + Expressions.Acquittance;
    }
}