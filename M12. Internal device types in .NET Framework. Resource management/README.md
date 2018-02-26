## Material Content 
- *Внутреннее устройство .NET Framework. Отладчик WinDbg.*
- *Сборщик мусора. Техники оптимизации.  События и сборщик мусора. Слабые ссылки и события.*
- *Финализаторы.*
- *Интерфейс IDisposable, методы Dispose и Close. Паттерн Dispose.*

## Источники
- [Pro .NET Performance: Optimize Your C# Applications. Goldshtein, S., Zurbalev, D., Group, S., Flatow, I. Apress. 2012](http://www.apress.com/us/book/9781430244585)
   - *Chapter 3.* Type Internals. [Download Example Code](https://github.com/Apress/pro-.net-perf/tree/master/Ch03)
   - *Chapter 4.* Garbage Collection. [Download Example Code](https://github.com/Apress/pro-.net-perf/tree/master/Ch04)
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do) 
   - *Chapter 8.* Basics of Exceptions and Resource Management. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch08.zip)
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 12.* Disposal and Garbage Collection. [Code Listings](http://www.albahari.com/nutshell/cs4ch12.aspx)
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 19.* Language Integrated Query Essentials.
   - *Chapter 20.* Language Integrated Query Internals
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 21.* The Managed Heap and Garbage Collection.
- [Внутреннее устройство .NET Framework — как CLR создает объекты периода выполнения (RU)](https://msdn.microsoft.com/ru-ru/library/dd335945.aspx?f=255&MSPPError=-2147217396)

## Презентации 
- Internal device types in .NET Framework (ENG)
- Resource management (ENG)
- [Internal device types in .NET Framework (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M12.%20Internal%20device%20types%20in%20.NET%20Framework.%20Resource%20management/Internal%20device%20types%20in%20.NET%20Framework.pptx)
- [Resource management (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M12.%20Internal%20device%20types%20in%20.NET%20Framework.%20Resource%20management/Resource%20management.pptx)

## Примеры 
- [LINQPad](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M12.%20Internal%20device%20types%20in%20.NET%20Framework.%20Resource%20management/Samples/LINQPad%205/Resource%20management) 
- [Visual Studio 2015](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M12.%20Internal%20device%20types%20in%20.NET%20Framework.%20Resource%20management/Samples/VS15) 

## Задачи  
**Цели:** 
- *понимание внутренненего устройства типов .NET.*
   
Рассмотреть специфику работы в .NET с ссылочными типами (на примере класса Employee) и типами значений (на примере структуры Point2D) с использованием расширения SOS Debugging Extension (SOS.dll) для отладчика Windows WinDbg.exe и дизассемблирования (Visual Studio) в контексте вызова не виртуальных и виртуальных методов, унаследованных от System. Объект (переопределенных и не переопределенных), а также методы интерфейсов, таблицы методов, структуры EEClass и т.д.

   public struct Point2D : IComparable 
   {
	   public int X { get; set; }
	   public int Y { get; set; }
   }
   
Результат оформить в виде скриншотов и коротких выводов.
https://github.com/AnzhelikaKravchuk/.NET-Training/wiki/.NET-Type-Internals  и глава 3 (TYPE INTERNALS) книги Pro .NET Performance. 
