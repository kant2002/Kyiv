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
        машина.ЗаписатиПамять(ячейка, (ulong)число);
    }

    [Given("ячейка {int} містить максимальне позітивне число")]
    public void ПрипустимоЯчейкаМіститьМаксимальнеПозітивнеЧисло(int ячейка)
    {
        машина.ЗаписатиПамять(ячейка, 1UL << 40);
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
        Assert.Equal((ulong)число, машина.ПрочитатиПамять(ячейка));
    }

    [Then("лічільник команд містить {int}")]
    public void ТоЛічільникКомандМістить(int число)
    {
        Assert.Equal((ushort)число, машина.РегістрС);
    }
}
