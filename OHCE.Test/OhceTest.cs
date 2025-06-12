using OHCE.Test.Utilities;
using OHCE_Prof.Langue;

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
        var résultat = DétecteurPalindromeBuilder.Default().Inverser(chaîne);

        // ALORS elle est renvoyée à l'envers
        Assert.Contains(attendu, résultat);
    }

    [Fact]
    public void PalindromeBienDit()
    {
        // ETANT DONNE un palindrome
        // ET un détecteur réglé pour une langue
        const string palindrome = "kayak";
        ushort nombreAppelsAFéliciter = 0;

        var langueSpy = new LangueMock(() =>
        {
            nombreAppelsAFéliciter++;
            return string.Empty;
        });

        var détecteurPalindrome = new DétecteurPalindromeBuilder()
            .AyantPourLangue(langueSpy)
            .Build();

        // QUAND on envoie le palindrome au détecteur
        var résultat = détecteurPalindrome.Inverser(palindrome);
        
        // ALORS il est renvoyé
        // ET les félicitations de cette langue sont écrites sur la ligne suivante.
        Assert.Contains(palindrome + Environment.NewLine + langueSpy.Féliciter(), résultat);
        Assert.NotEqual(0, nombreAppelsAFéliciter);
    }

    [Fact]
    public void PasBienDitPasPalindrome()
    {
        // ETANT DONNE une chaîne n'étant pas un palindrome
        const string nonPalindrome = "cookie";

        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindromeBuilder.Default()
            .Inverser(nonPalindrome);

        // ALORS "Bien dit !" est absent
        Assert.DoesNotContain(Expressions.Félicitations, résultat);
    }

    [Theory]
    [InlineData("test")]
    [InlineData("kayak")]
    public void BonjourAvantRéponse(string chaîne)
    {
        // ETANT DONNE une chaîne
        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindromeBuilder.Default()
            .Inverser(chaîne);

        // ALORS "Bonjour" est renvoyé sur la ligne précédant la réponse
        Assert.StartsWith(Expressions.Salutations + Environment.NewLine, résultat);
    }

    [Theory]
    [InlineData("test")]
    [InlineData("kayak")]
    public void AuRevoirAprèsRéponse(string chaîne)
    {
        // ETANT DONNE une chaîne
        // QUAND on l'envoie au détecteur de palindrome
        var résultat = DétecteurPalindromeBuilder.Default()
            .Inverser(chaîne);

        // ALORS "Au revoir." est renvoyé sur la dernière ligne
        Assert.EndsWith(Environment.NewLine + Expressions.Acquittance, résultat);
    }
}