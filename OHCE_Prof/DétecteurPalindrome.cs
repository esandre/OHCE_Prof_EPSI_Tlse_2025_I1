namespace OHCE_Prof;

public class DétecteurPalindrome
{
    public static string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return "Bonjour" + Environment.NewLine + miroir + Environment.NewLine + "Bien dit !";
        return "Bonjour" + Environment.NewLine + miroir;
    }
}