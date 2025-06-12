using System.Text;
using OHCE_Prof.Langue;

namespace OHCE.Test.Utilities
{
    internal class LangueAléatoire : ILangue
    {
        private readonly string _félicitations;

        public LangueAléatoire()
        {
            var buffer = new byte[64];
            Random.Shared.NextBytes(buffer);
            _félicitations = Encoding.Default.GetString(buffer);
        }

        public string Féliciter() => _félicitations;
    }
}
