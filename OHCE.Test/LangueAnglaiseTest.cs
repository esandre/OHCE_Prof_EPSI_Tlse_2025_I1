using OHCE_Prof.Langue;

namespace OHCE.Test;

public class LangueAnglaiseTest
{
    [Fact]
    public void GoodMorningLeMatin()
    {
        Assert.Equal("Good Morning", new LangueAnglaise().Saluer(new TimeOnly(6)));
        Assert.Equal("Good Morning", new LangueAnglaise().Saluer(new TimeOnly(11, 59)));
    }
}