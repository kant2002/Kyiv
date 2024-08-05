namespace Kyiv.Tests;

public class ТестиПарсераКоманд
{
    [Fact]
    public void КомандаТекстом()
    {
        var результат = ПарсерКоманд.Розібрати("31 0005 0022 3146");

        Assert.Equal(КодОперації.УсловныйПереходПоЗнакуЧисла, результат.Код);
        Assert.Equal(5, результат.Адреса1);
        Assert.Equal(2*8+2, результат.Адреса2);
        Assert.Equal(3 * 8 * 8 * 8 + 1 * 8 * 8 + 4 * 8 + 6, результат.Адреса3);
    }

    [Fact]
    public void КомандаТекстом2()
    {
        var результат = ПарсерКоманд.Розібрати("31\t0005 0022 3146");

        Assert.Equal(КодОперації.УсловныйПереходПоЗнакуЧисла, результат.Код);
        Assert.Equal(5, результат.Адреса1);
        Assert.Equal(2 * 8 + 2, результат.Адреса2);
        Assert.Equal(3 * 8 * 8 * 8 + 1 * 8 * 8 + 4 * 8 + 6, результат.Адреса3);
    }

    [Fact]
    public void КомандаЧислом()
    {
        var результат = ПарсерКоманд.Розібрати(0x19_005_012_666UL);

        Assert.Equal(КодОперації.УсловныйПереходПоЗнакуЧисла, результат.Код);
        Assert.Equal(5, результат.Адреса1);
        Assert.Equal(2 * 8 + 2, результат.Адреса2);
        Assert.Equal(3 * 8 * 8 * 8 + 1 * 8 * 8 + 4 * 8 + 6, результат.Адреса3);
    }

    [Fact]
    public void Сконвертувати()
    {
        var результат = ПарсерКоманд.Сконвертувати("31 0005 0022 3146");

        Assert.Equal(0x19_005_012_666UL, результат);
    }

    [Fact]
    public void Сконвертувати2()
    {
        var результат = ПарсерКоманд.Сконвертувати("31 0005\t0022 3146");

        Assert.Equal(0x19_005_012_666UL, результат);
    }

    [Fact]
    public void Сконвертувати3()
    {
        var результат = ПарсерКоманд.Сконвертувати("00 2001 0004 0020");

        Assert.Equal(0x40_100_4010UL, результат);
        Assert.Equal("00 2001 0004 0020", ПарсерКоманд.Сконвертувати(результат));
    }
}