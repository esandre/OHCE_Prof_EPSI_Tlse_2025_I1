using OHCE_Prof;

namespace OHCE.Test;

public class OhceTest
{
    [Theory]
    [InlineData("test", "tset")]
    [InlineData("kayak", "kayak")]
    public void RenvoieInversé(string chaîne, string attendu)
    {
        // ETANT DONNE une chaîne
        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindrome.Inverser(chaîne);

        // ALORS elle est renvoyée à l'envers
        Assert.Equal(attendu, résultat);
    }
}