namespace OHCE_Prof.Langue;

public class LangueAnglaise : ILangue
{
    public string Féliciter()
    {
        return Expressions.Congratulations;
    }

    public string Saluer()
    {
        return Expressions.Hello;
    }
}