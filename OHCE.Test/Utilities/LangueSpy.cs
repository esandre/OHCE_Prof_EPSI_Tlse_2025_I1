namespace OHCE.Test.Utilities;

internal class LangueSpy : LangueStub
{
    public ushort NombreAppelsAFéliciter { get; private set; }

    public override string Féliciter()
    {
        NombreAppelsAFéliciter++;
        return base.Féliciter();
    }
}