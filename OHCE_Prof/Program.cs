namespace OHCE_Prof
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine() ?? throw new InvalidOperationException("Aucune saisie");
                Console.WriteLine(input + " => " + new DétecteurPalindrome(new LangueFrançaise()).Inverser(input));
            }
        }
    }
}
