## Основное содержание материала 
- *Объявление и вызов методов.*
- *Соглашение именования.*
- *Разрешение перегрузки (overload resolution).*
- *Обязательные и опциональные параметры, именованные аргументы, массив параметров (params).*
- *Передача параметров по значению и по ссылке (ref, out -параметры). Возможности С# 6.0, C# 7.0.*
- *Статические методы и статические конструкторы.*
- *Статические классы. Сценарии использования. Методы расширения. Перегрузка операций.*

## Источники 
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
    - *Chapter 10:* Methods
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
    - *Chapter 8:* Methods

## Презентации 
- [Methods in details (ENG)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M4.%20Methods%20in%20details/M4.%20Methods%20in%20details%20(ENG).pdf)
- [Methods in details (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M4.%20Methods%20in%20details/M4.%20Methods%20in%20details%20(RU).pdf)

## Примеры 
[LINQPad Samples](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M4.%20Methods%20in%20details/Samples/LINQPad%205)

## Задачи 
**Цели:** 
- *изучить методы расширения;* 
- *ознакомиться с форматом представления вещественных чисел стандарта IEEE 754.* 

1. Расширить функциональную возможность типа System.Double, реализовав возможность получения строкового представления вещественного числа в формате IEEE 754. Готовые классы-конверторы не использовать. Разработать модульные тесты. Примерные тест-кейсы
    - [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
    - [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
    - [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
    - [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
    - [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
    - [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
    - [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
    - [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
    - [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
    - [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
    - [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")] и т.д.



Implement a binary representation of a real double-precision number in IEEE 754 format as the extension method. 
2. Develop a class that allows performing Greatest Common Divisor (GCD) computations using Euclid's algorithm for two, three, etc. of integers. The methods of class should be able to determine the GCD calculation time (consider three possible oportunities for returning more than one value from the method). Add to the class methods that implement the Stein algorithm (Euclid's binary algorithm) to calculate GCD of two, three, etc. of integers. These methods should be able to determine the GCD calculation time too.
3. Write two basic extention methods: SayHello and SayGoodbye. 
   Examples: string name = "Kathy"
    - name.SayHello() --> "Hello, Kathy!"
    - name.SayGoodbye() --> "Goodbye, Kathy. See you again soon!"
