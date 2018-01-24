## Основное содержание материала 
- *локальные переменные, var-стиль объявления переменных.*
- *соглашения именования.*
- *выражения и операции.*
- *комментарии.*
- *XML-комментарии. Создание XML документации, Sandcastle.*
- *Внутренние типы данных. Числовые данные. Числовые преобразования. Типы System.Boolean, System.Strings, System.Char, System.Object (обзор).*
- *Основные операторы.*

## Источники
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 4.* Language Essentials
   - *Chapter 5.* Expressions and Operators
   - *Chapter 6.* A Primer on Types and Objects
   - *Chapter 7.* Simple Control Flow
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
   - *Chapter 2.* Basic Coding in C# [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch02.zip)
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 1.* Introducing C# and the .NET Framework [Code Listings](http://www.albahari.com/nutshell/ch01.aspx)
   - *Chapter 2.* C# Language Basics [Code Listings](http://www.albahari.com/nutshell/ch02.aspx)
- [Sandcastle - Documentation Compiler for Managed Class Libraries](https://sandcastle.codeplex.com/)
- [Know Thy Complexities!](http://bigocheatsheet.com/)
- [Что нужно знать про арифметику с плавающей запятой](https://habrahabr.ru/post/112953/ )
- [StyleCop](https://github.com/StyleCop)

## Презентации 
- Basic Coding in C# (ENG)
- [Basic Coding in C# (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M2.%20Basic%20Coding%20in%20C%23/M2.%20Basic%20Coding%20in%20C%23%207.0.pdf)

## Примеры 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M2.%20Basic%20Coding%20in%20C%23/Samples/LINQPad%205)

## Задачи  
**Цели:** 
- *изучить классы System.Array и System.String;* 
- *изучить алгоритмы поиска и сортировки.*

1. Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода. (Ниже пояснение к алгоритму).
![Схема к алгоритму](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/Pictures/Scheme.png)
2. Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
3. Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null (или -1).
4. Реализовать алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, исключая повторяющиеся символы.
5. Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.
   - Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода. Примерные тест-кейсы
      - [TestCase(12, ExpectedResult = 21)]
      - [TestCase(513, ExpectedResult = 531)]
      - [TestCase(2017, ExpectedResult = 2071)]
      - [TestCase(414, ExpectedResult = 441)]
      - [TestCase(144, ExpectedResult = 414)]
      - [TestCase(1234321, ExpectedResult = 1241233)]
      - [TestCase(1234126, ExpectedResult = 1234162)]
      - [TestCase(3456432, ExpectedResult = 3462345)]
      - [TestCase(10, ExpectedResult = -1)]           	
      - [TestCase(20, ExpectedResult = -1)]
   - Добавить к методу FindNextBiggerNumber возможность вернуть время нахождения заданного числа, рассмотрев различные языковые возможности. Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода.
6. Реализовать метод FilterDigit который принимает массив целых чисел и фильтрует его таким образом, чтобы на выходе остались только числа, содержащие заданную цифру (LINQ-запросы не использовать!) Например, для цифры 7, FilterDigit (7,1,2,3,4,5,6,7,68,69,70, 15,17) -> {7, 70, 17}. Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода. 
