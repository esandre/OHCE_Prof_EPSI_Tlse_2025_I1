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

    public static IEnumerable<object[]> LanguesPossibles()
    {
        yield return [new LangueAléatoire()];
        yield return [new LangueStub()];
    }

    [Theory]
    [MemberData(nameof(LanguesPossibles))]
    public void PalindromeBienDit(ILangue langue)
    {
        // ETANT DONNE un palindrome
        // ET un détecteur réglé pour la langue <langue>
        const string palindrome = "kayak";

        var détecteurPalindrome = new DétecteurPalindromeBuilder()
            .AyantPourLangue(langue)
            .Build();

        // QUAND on envoie le palindrome au détecteur
        var résultat = détecteurPalindrome.Inverser(palindrome);
        
        // ALORS il est renvoyé
        // ET les félicitations de cette langue sont écrites sur la ligne suivante.
        Assert.Contains(palindrome + Environment.NewLine + langue.Féliciter(), résultat);
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

    public static IEnumerable<object[]> LanguesEtChaînesPossibles()
    {
        yield return [new LangueAléatoire(), "test"];
        yield return [new LangueAléatoire(), "kayak"];
        yield return [new LangueStub(), "test"];
        yield return [new LangueStub(), "kayak"];
    }

    // 6:00 - 11h59 - Matin
    // 12:00 - 17h59 - Après-midi
    // 18:00 - 20h59 - Soirée
    // 21h - 5:59 - Nuit

    [Theory]
    [MemberData(nameof(LanguesEtChaînesPossibles))]
    public void SalutationsMatinAvantRéponse(ILangue langue, string chaîne)
    {
        // ETANT DONNE une chaîne
        // ET un détecteur de palindrome configuré pour une langue
        // ET que nous sommes le matin
        var heure = new TimeOnly(6, 00);
        var détecteurPalindrome = new DétecteurPalindromeBuilder()
            .AyantPourLangue(langue)
            .AyantUneHorlogeFixéeA(heure)
            .Build();

        // QUAND on envoie la chaîne au détecteur de palindrome
        var résultat = détecteurPalindrome.Inverser(chaîne);

        // ALORS les salutations matinales de cette langue sont renvoyés sur la ligne précédant la réponse
        Assert.StartsWith(langue.Saluer(heure) + Environment.NewLine, résultat);
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