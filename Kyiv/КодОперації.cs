﻿namespace Kyiv;

public enum КодОперації
{
    Простой = 0,
    
    /// <summary>
    /// Операция заключается в сложении чисел, номера ячеек которых указаны в первом и втором адресах, и передаче результатов по третьему адресу.
    /// </summary>
    Сложение = 01,

    /// <summary>
    /// Из числа, номер ячейки которого указан в первом адресе, вычитается число, номер ячейки которого указан во втором адресе. Результат направляется в ячейку, номер которой дан в третьем адресе.
    /// </summary>
    Вычитание = 02,

    /// <summary>
    /// В первом адресе указывается номер ячейки, содержащей число, прибавляемое к команде. Оно
    /// может быть положительным или отрицательным. Во втором адресе
    /// указывается номер ячейки, содержащей изменяемую команду
    /// (можно изменять коды всех адресов команды и четыре младших
    /// разряда кода операции). В третьем адресе указывается адрес
    /// измененной команды. При выходе из числа располагаемых разрядов происходит автоматический останов машины.
    /// </summary>
    СложениеКоманд = 03,

    /// <summary>
    /// Если первое число равно
    /// второму или меньше его, осуществляется переход к команде,
    /// номер которой указан в третьем адресе; если первое число больше
    /// второго, происходит переход к следующей по номеру команде.
    /// </summary>
    СравнениеСУчетомЗнаков = 04,

    /// <summary>
    /// Операция выполняется
    /// аналогично команде Ср1, но без учета знаков сравниваемых
    /// чисел.
    /// </summary>
    СравнениеБезУчетаЗнаков = 05,

    /// <summary>
    /// Операция выполняется аналогично операции вычитания, но без учета знаков чисел.
    /// </summary>
    ВычитаниеПоМодулю = 06,

    /// <summary>
    /// Операция отличается от обычного сложения отсутствием блокировки при выходе из числа
    /// располагаемых разрядов. Перенос из разряда знака поступает
    /// на младший разряд сумматора. Операция используется в основном при вычислении контрольных сумм
    /// </summary>
    ЦиклическоеСложение = 07,

    /// <summary>
    /// Операция отличается от 
    /// предыдущей операции отсутствием округления результата.
    /// </summary>
    УмножениеБезОкругления = 8 /*010*/,

    /// <summary>
    /// В первом адресе помещается номер ячейки, в которой находится множитель, во втором —
    /// ячейки, в которой находится множимое. Результат округляется
    /// добавлением единицы в старший отбрасываемый разряд.
    /// </summary>
    УмножениеСОкруглением = 9 /*011*/,

    /// <summary>
    /// В первом адресе помещен номер ячейки, хранящей делимое, во втором — ячейки, в которой находился делитель. Если делимое больше делителя, машина автоматически
    /// останавливается либо пропускается очередная команда.
    /// </summary>
    Деление = 10 /*012*/,

    /// <summary>
    /// В первом адресе указывается номер ячейки, в которой расположена константа сдвига — число,
    /// указывающее, на сколько разрядов нужно сдвинуть число, содержащееся по второму адресу. Направление сдвига определяется
    /// знаком константы: при отрицательном знаке число сдвигается
    /// вправо, при положительном — влево. Количество сдвигов кодируется в шести младших разрядах константы сдвига. После
    /// сдвига число направляется по третьему адресу.
    /// При выполнении логических операций разряд знака участвует в операции наравне с другими разрядами кодов.
    /// </summary>
    ЛогическийСдвиг = 11 /*013*/,

    /// <summary>
    /// Эта операция выполняется поразрядно по следующей логической схеме:
    /// А1  А2  А3
    /// О   О   О
    /// 1   0   1
    /// О   1   1
    /// 1   1   1
    /// Результат направляется по третьему адресу.
    /// </summary>
    ЛогическоеСложение = 12 /*014*/,

    /// <summary>
    /// Эта операция выполняется поразрядно по следующей логической схеме:
    /// А1  А2  А3
    /// О   О   О
    /// 1   0   О
    /// О   1   О
    /// 1   1   1
    /// Результат направляется по третьему адресу.
    /// </summary>
    ЛогическоеУмножение = 13 /*015*/,

    /// <summary>
    /// Если первое число совпадает со
    /// вторым (включая знак), то осуществляется переход к команде,
    /// номер которой указан в третьем адресе. Если коды не совпадают, происходит переход к следующей по номеру команд
    /// </summary>
    ТочноеСравнение = 14 /*016*/,

    /// <summary>
    /// Эта операция выполняется поразрядно по следующей логической схеме:
    /// А1  А2  А3
    /// О   О   1
    /// 1   0   О
    /// О   1   О
    /// 1   1   1
    /// Результат направляется по третьему адресу.
    /// </summary>
    ОперацияРавнозначно = 15 /*017*/,

    /// <summary>
    /// Эти операции предназначены для ввода данных в ячейки оперативного запоминающего устройства.
    /// При вводе чисел арифметическое устройство преобразует
    /// двоично-десятичные коды в двоичные, а при вводе команд передает их коды в запоминающее устройство без изменения. В первом адресе команды указывается номер ячейки, в которую должно
    /// попасть первое вводимое число (команда); во втором адресе —
    /// номер ячейки, в которую должно быть введено последнее вводимое число (команда); в третьем — номер зоны на перфоленте,
    /// где расположен вводимый массив кодов.
    /// </summary>
    ВводЧисел = 16 /*020*/,

    /// <summary>
    /// Эти операции предназначены для ввода данных в ячейки оперативного запоминающего устройства.
    /// При вводе чисел арифметическое устройство преобразует
    /// двоично-десятичные коды в двоичные, а при вводе команд передает их коды в запоминающее устройство без изменения. В первом адресе команды указывается номер ячейки, в которую должно
    /// попасть первое вводимое число (команда); во втором адресе —
    /// номер ячейки, в которую должно быть введено последнее вводимое число (команда); в третьем — номер зоны на перфоленте,
    /// где расположен вводимый массив кодов.
    /// </summary>
    ВводКоманд = 17 /*021*/,

    /// <summary>
    /// Операция предназначена для вывода
    /// кодов на перфоратор результатов или цифропечатающее устройство. В команде указываются номера начальной и конечной ячеек
    /// запоминающего устройства, из которых должны быть выведены
    /// коды, и номер команды, куда следует перейти после окончания
    /// вывода. Коды из двоичной системы в десятичную преобразуются
    /// по подпрограмме и выводятся в десятичной и восьмеричной системах.
    /// </summary>
    /// <remarks>
    /// Обмен кодами между магнитными барабанами и оперативным
    /// запоминающим устройством осуществляется одной подготовительной командой и одной из двух исполнительных
    /// </remarks>
    ВыводКодов = 18 /*022*/,

    /// <summary>
    /// МЗб— команда исполнительная. В ее первом адресе указывается номер ячейки запоминающего устройства, с которой начинается обмен кодами с магнитным
    /// барабаном, во втором —номер ячейки, на которой заканчивается
    /// обмен кодами, а в третьем — номер команды, к которой следует
    /// перейти после окончания обмена кодами.
    /// </summary>
    ЗаписьНаМагнитныйБарабанКодовИзЯчеекЗапоминающегоУстройств = 19 /*023*/,

    /// <summary>
    /// МЗб— команда исполнительная. В ее первом адресе указывается номер ячейки запоминающего устройства, с которой начинается обмен кодами с магнитным
    /// барабаном, во втором —номер ячейки, на которой заканчивается
    /// обмен кодами, а в третьем — номер команды, к которой следует
    /// перейти после окончания обмена кодами.
    /// </summary>
    ЧтениеКодовСМагнитногоБарабанаВЯчейкиЗапоминающегоУстройства = 20 /*024*/,

    /// <summary>
    /// МЗа— команда подготовительная. В первом адресе команды МЗа указывается, что нужно
    /// выполнить считывание или запись, во втором —номер барабана
    /// и номер тракта, а в третьем —номер места на тракте, с которого нужно начать обмен кодами
    /// </summary>
    ОбращениеКМагнитномуБарабану = 21 /*025*/,

    НачалоГрупповойОперации = 22 /*026*/,
    ОкончаниеГрупповойОперации = 23 /*027*/,

    /// <summary>
    /// Управление передается в зависимости от знака числа (признака), номер которого
    /// указывается в первом адресе. Если знак числа положительный,
    /// выполняется следующая по номеру команда; если знак отрицательный, то происходит переход на подпрограмму, номер начальной команды которой указан в третьем адресе. При этом в регистр возврата заносится из второго адреса номер команды,
    /// к которой следует перейти после выполнения подпрограммы.
    /// </summary>
    УсловныйПереходНаПодпрограмму = 24 /*030*/,

    /// <summary>
    /// По команде УП
    /// в зависимости от знака числа (признака), номер которого указан
    /// в первом адресе, управление может быть передано по двум направлениям. Если знак числа положительный, то осуществляется
    /// переход к команде, номер которой указан во втором адресе; если
    /// отрицательный — в третьем адресе.
    /// </summary>
    УсловныйПереходПоЗнакуЧисла = 25 /*031*/,

    /// <summary>
    /// При операции ПРВ
    /// выполняется переход к заранее заданному номеру команды основной программы после окончания выполнения подпрограммы.
    /// Этот номер засылается в регистр возврата при выполнении команды УПП
    /// </summary>
    ПереходПоРегиструВозврата = 26 /*032*/,

    /// <summary>
    /// Операция служит для программного останова машин.
    /// </summary>
    ОстановМашины = 27 /*033*/,

    /// <summary>
    /// Операция пересылает код из
    /// одной ячейки запоминания, адрес которой указан в ячейке, адрес
    /// которой указан в команде, в другую ячейку запоминающего
    /// устройства.
    /// </summary>
    ПереходПоФиксатору = 28 /*034*/,

    /// <summary>
    /// Нормализуется число, расположенное
    /// в ячейке, номер которой указан в первом адресе, после чего оно
    /// направляется по третьему адресу, а произведенное количество
    /// сдвигов — по второму.
    /// </summary>
    Нормализация = 29 /*035*/,
}
