namespace OHCE_Prof;

public class DétecteurPalindrome
{
    public static string Inverser(string chaîne)
    {
        var miroir = new string(chaîne.Reverse().ToArray());

        if (miroir.Equals(chaîne))
            return miroir + Environment.NewLine + "Bien dit !";
        return miroir;
    }
}