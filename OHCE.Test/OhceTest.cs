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
        Assert.Contains(attendu, résultat);
    }

    [Fact]
    public void PalindromeBienDit()
    {
        // ETANT DONNE un palindrome
        const string palindrome = "kayak";

        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindrome.Inverser(palindrome);
        
        // ALORS il est renvoyé
        // ET "Bien dit !" est écrit sur la ligne suivante.
        Assert.Equal(palindrome + Environment.NewLine + "Bien dit !", résultat);
    }

    [Fact]
    public void PasBienDitPasPalindrome()
    {
        // ETANT DONNE une chaîne n'étant pas un palindrome
        const string nonPalindrome = "cookie";

        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindrome.Inverser(nonPalindrome);

        // ALORS "Bien dit !" est absent
        Assert.DoesNotContain("Bien dit !", résultat);
    }
}