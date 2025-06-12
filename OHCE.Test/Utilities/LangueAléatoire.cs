using System.Text;
using OHCE_Prof.Langue;

namespace OHCE.Test.Utilities
{
    internal class LangueAléatoire : ILangue
    {
        private readonly string _félicitations;
        private readonly string _salutations;

        public LangueAléatoire()
        {
            var buffer = new byte[64];

            Random.Shared.NextBytes(buffer);
            _félicitations = Encoding.Default.GetString(buffer);

            Random.Shared.NextBytes(buffer);
            _salutations = Encoding.Default.GetString(buffer);
        }

        public string Féliciter() => _félicitations;

        public string Saluer(TimeOnly heure) => _salutations;
    }
}
