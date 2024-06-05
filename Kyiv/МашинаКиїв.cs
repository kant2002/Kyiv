﻿using System;
using System.Diagnostics;

namespace Kyiv;

public class МашинаКиїв
{
    /// <summary>
    /// счетчик команд
    /// </summary>
    /// <remarks>11-бітний</remarks>
    public ushort РегістрС;

    /// <summary>
    /// регистр команд
    /// </summary>
    /// <remarks>41-бітний</remarks>
    public ulong РегістрК;

    /// <summary>
    /// регистр возврата
    /// </summary>
    /// <remarks>11-бітний</remarks>
    public ushort РегістрР;

    /// <summary>
    /// регистр циклов 
    /// </summary>
    /// <remarks>11-бітний</remarks>
    public ushort РегістрЦ;

    /// <summary>
    /// регистра модификации адресов
    /// </summary>
    /// <remarks>11-бітний</remarks>
    public ushort РегістрА;

    /// <summary>
    /// регистр-триггер аварийного останова
    /// </summary>
    public bool АварійнаЗупинка;

    /// <summary>
    /// тумблер блокировки аварийного останова
    /// </summary>
    public bool ТумблерБлокировкиАварийногоОстанова;

    public ulong[] ОперативноеЗапоминающееУстройство = new ulong[1024];
    public ulong[] ПассивноеЗапоминающееУстройство = new ulong[512];
    public ulong[] ВнешняяПамять = new ulong[9864];

    private int ВзятиВідноснуАдреса(int адреса)
    {
        if ((адреса & (1 << 11)) != 0)
        {
            return адреса + РегістрА;
        }

        return адреса;
    }

    public ulong ПрочитатиПамять(int адреса)
    {
        if (адреса == 0) return 0;

        if (адреса < 1024) return ОперативноеЗапоминающееУстройство[адреса];

        if (адреса < 2047) return ПассивноеЗапоминающееУстройство[адреса - 1536];
        if (адреса == 2047)
        {
            // Последняя ячейка пятого блока сменно-спаянной памяти (имеющая адрес 3777) используется для подсоединения датчика случайных чисел
            Debug.Assert(false, "Датчик випадкових чисел не реалізован");
        }

        Debug.Assert(false, $"Невідома адреса {адреса}");
        return 0;
    }

    public void ЗаписатиПамять(int адреса, ulong значення)
    {
        //адреса = адреса - 2048;
        if (адреса == 0)
        {
            // Последняя ячейка пятого блока сменно-спаянной памяти (имеющая адрес 3777) используется для подсоединения датчика случайных чисел
            Debug.Assert(false, "Значення 0 не можна міняти");
        }

        if (адреса < 1024)
        {
            ОперативноеЗапоминающееУстройство[адреса] = значення;
            return;
        }
        if (адреса < 2047)
        {
            ПассивноеЗапоминающееУстройство[адреса - 1536] = значення;
            return;
        }

        if (адреса == 2047)
        {
            // Последняя ячейка пятого блока сменно-спаянной памяти (имеющая адрес 3777) используется для подсоединения датчика случайных чисел
            Debug.Assert(false, "Датчик випадкових чисел не реалізован");
        }

        Debug.Assert(false, $"Невідома адреса {адреса}");
    }

    public void ВиконатиКоманду()
    {
        ВиконатиКоманду(ПарсерКоманд.Розібрати(РегістрК));
    }

    public void ВиконатиКоманду(СтруктураКоманди команда)
    {
        switch (команда.Код)
        {
            // ст. 55
            case КодОперації.Сложение:
                {
                    var значення1 = ПрочитатиПамять(ВзятиВідноснуАдреса(команда.Адреса1));
                    var значення2 = ПрочитатиПамять(ВзятиВідноснуАдреса(команда.Адреса2));
                    var значення = значення1 + значення2;
                    if (ЄПереповнення(значення))
                    {
                        if (АварійнаЗупинка && !ТумблерБлокировкиАварийногоОстанова)
                        {
                            Debug.Assert(false, $"Машина зупинена");
                        }
                        else
                        {
                            РегістрС += 2;
                        }
                    }
                    else
                    {
                        ЗаписатиПамять(ВзятиВідноснуАдреса(команда.Адреса3), значення);
                        РегістрС += 1;
                        РегістрК = ПрочитатиПамять(РегістрС);
                    }
                }
                break;
            default:
                throw new NotImplementedException($"Команда {команда.Код} не реалізована");
        }    
    }

    public static bool ЄЗнак(ulong значення)
    {
        if ((значення & (1UL << 41)) != 0)
        {
            return true;
        }

        return false;
    }

    public static bool ЄПереповнення(ulong значення)
    {
        if ((значення & (1UL << 42)) != 0)
        {
            return true;
        }

        return false;
    }
}
