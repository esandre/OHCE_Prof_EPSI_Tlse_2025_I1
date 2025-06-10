namespace OHCE_Prof;

public class DétecteurPalindrome
{
    public static string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return "Bonjour" + Environment.NewLine + miroir + Environment.NewLine + "Bien dit !" + Environment.NewLine + "Au revoir.";
        return "Bonjour" + Environment.NewLine + miroir + Environment.NewLine + "Au revoir.";
    }
}