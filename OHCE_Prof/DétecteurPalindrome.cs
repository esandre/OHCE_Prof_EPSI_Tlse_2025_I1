namespace OHCE_Prof;

public class DétecteurPalindrome
{
    public static string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return Expressions.Salutations + Environment.NewLine + miroir + Environment.NewLine + Expressions.Félicitations + Environment.NewLine + Expressions.Acquittance;
        return Expressions.Salutations + Environment.NewLine + miroir + Environment.NewLine + Expressions.Acquittance;
    }
}