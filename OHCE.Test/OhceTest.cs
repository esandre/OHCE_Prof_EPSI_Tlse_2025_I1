using OHCE_Prof;

namespace OHCE.Test
{
    public class OhceTest
    {
        [Fact]
        public void RenvoieInversé()
        {
            // ETANT DONNE une chaîne
            const string chaîne = "test";

            // QUAND on l'envoie au détecteur de palindrome
            var résultat = DétecteurPalindrome.Inverser(chaîne);

            // ALORS elle est renvoyée à l'envers
            const string attendu = "tset";
            Assert.Equal(attendu, résultat);
        }
    }
}