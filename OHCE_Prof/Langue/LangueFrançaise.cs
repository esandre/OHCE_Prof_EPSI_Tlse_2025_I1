namespace OHCE_Prof.Langue;

public class LangueFrançaise : ILangue
{
    public string Féliciter()
    {
        return Expressions.Félicitations;
    }

    public string Saluer(TimeOnly heure)
    {
        return Expressions.Salutations;
    }
}