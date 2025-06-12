using OHCE_Prof.Langue;

namespace OHCE.Test.Utilities
{
    internal class LangueMock : ILangue
    {
        private readonly Func<string> _commentFéliciter;

        public LangueMock(Func<string> commentFéliciter)
        {
            _commentFéliciter = commentFéliciter;
        }

        public string Féliciter() => _commentFéliciter();
    }
}
