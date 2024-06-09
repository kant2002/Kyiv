﻿using Reqnroll;
using Reqnroll.UnitTestProvider;

namespace Kyiv.Tests;

[Binding]
public class КрокиМашини(IUnitTestRuntimeProvider unitTestRuntimeProvider)
{
    МашинаКиїв машина = new МашинаКиїв();

    [Given("пам'ять заповнена значенями {int}")]
    public void ДаноПамятьЗаповненаЗначенями(int число)
    {
        // 0 неможна міняти
        for (int i = 1; i < 1024; i++)
        {
            машина.ЗаписатиПамять(i, (ulong)число);
        }
    }

    [Given("ячейка {int} містить {int}")]
    public void ПрипустимоЯчейкаМістить(int ячейка, int число)
    {
        машина.ЗаписатиПамять(ячейка, ЗвузитиЧисло(число));
    }

    private static ulong ЗвузитиЧисло(long значення)
    {
        if (значення > 0) return unchecked((ulong)значення);

        return unchecked((ulong)-значення) | (1UL << 40);
    }

    [Given("ячейка {int} містить максимальне позітивне число")]
    public void ПрипустимоЯчейкаМіститьМаксимальнеПозітивнеЧисло(int ячейка)
    {
        машина.ЗаписатиПамять(ячейка, ulong.MaxValue >> 24);
    }

    [Given("ячейка {int} містить мінімальне негативне число")]
    public void ПрипустимоЯчейкаМіститьМінімальнеНегативнеЧисло(int ячейка)
    {
        машина.ЗаписатиПамять(ячейка, ulong.MaxValue >> 23);
    }

    [Given("ячейка {int} містить команду {string}")]
    public void ПрипустимоЯчейкаМіститьКоманду(int ячейка, string команда)
    {
        машина.ЗаписатиПамять(ячейка, ПарсерКоманд.Сконвертувати(команда));
    }

    [Given("регістр лічільник команд містить {int}")]
    public void ПрипустимоРегістрЛічільникКомандМістить(int ячейка)
    {
        машина.РегістрС = (ushort)ячейка;
        машина.РегістрК = машина.ПрочитатиПамять(машина.РегістрС);
    }

    [Given("аварійна зупинка включена")]
    public void ПрипустимоАварійнаЗупинкаВключена()
    {
        машина.АварійнаЗупинка = true;
        unitTestRuntimeProvider.TestIgnore("Аварійна зупинка не реалізована");
    }

    [When("виконати команді")]
    public void ЯкщоВиконатиКоманді()
    {
        машина.ВиконатиКоманду();
    }

    [Then("ячейка {int} містить {int}")]
    public void ТоЯчейкаМістить(int ячейка, int число)
    {
        Assert.Equal(ЗвузитиЧисло(число), машина.ПрочитатиПамять(ячейка));
    }

    [Then("лічільник команд містить {int}")]
    public void ТоЛічільникКомандМістить(int число)
    {
        Assert.Equal((ushort)число, машина.РегістрС);
    }

    [Then("ячейка {int} містить команду {string}")]
    public void ТоЯчейкаЗМіститьКоманду(int ячейка, string команда)
    {
        ячейка = (ячейка / 1000) * 8 * 8 * 8 + (ячейка % 1000 / 100) * 8 * 8 + (ячейка % 100 / 10) * 8 + ячейка % 10;
        Assert.Equal(команда, ПарсерКоманд.Сконвертувати(машина.ПрочитатиПамять(ячейка)));
    }
}
