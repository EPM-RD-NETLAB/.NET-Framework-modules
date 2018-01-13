## Основное содержание материала 
- *Ссылочные и значимые типы.*
- *Классы и структуры. Упаковка и распаковка. Соглашения именования.*
- *Статические и экземплярные классы.*
- *Члены типа - поля, констукторы, методы (свойства, индексаторы, перегруженные операции, события - обзор), вложенные типы. Перечисления.*
- *Статические типы и методы.*

## Источники 
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 3.* Creating Types in C# [Code Listings](http://www.albahari.com/nutshell/ch03.aspx)
   - *Chapter 7:* Collections. The Array Class
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013.](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 9.* Introducing Types
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
   - *Chapter 3.* Types [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch03.zip)
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 4.* Type Fundamentals
   - *Chapter 5.* Primitive, Reference, and Value Types
   - *Chapter 6.* Type and Member Basics
- [Know Thy Complexities!](http://bigocheatsheet.com/)
- [Arrays](https://msdn.microsoft.com/en-us/library/aa287879(v=vs.71).aspx)
- [Arrays Tutorial](https://msdn.microsoft.com/en-us/library/aa288453(v=vs.71).aspx)
- [Коллекции в .NET Framework Class Library. Массивы](http://rsdn.ru/article/dotnet/collections.xml#E2GAC)
- [C#: Внутреннее строение инициализаторов массивов](http://habrahabr.ru/post/247047/)

## Презентации 
- [Types (ENG)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M3.%20Types/Types.pptx)
- [Types (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M3.%20Types/Types%20(RU).pptx)

## Примеры 
[LINQPad](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M3.%20Types/Samples/LINQPad%205)

## Задачи  
**Цели:** 
- *понимать принцип инкапсуляции;*
- *изучить паттерн проектирования Strategy (стратегия).*

1. Реализовать алгоритм FindNthRoot, позволяющий вычислять корень n-ой степени ( n∈N ) из вещественного числа а методом Ньютона с заданной точностью. Разработать модульные тесты (NUnit и (или) MS Unit Test) для тестирования метода. Примерные тест кейсы:
   - [TestCase(1, 5, 0.0001,ExpectedResult =1)]
   - [TestCase(8, 3, 0.0001,ExpectedResult = 2)]
   - [TestCase(0.001, 3, 0.0001,ExpectedResult = 0.1)]
   - [TestCase(0.04100625,4 , 0.0001, ExpectedResult =0.45)]
   - [TestCase(8, 3, 0.0001, ExpectedResult =2)]
   - [TestCase(0.0279936, 7, 0.0001, ExpectedResult =0.6)]
   - [TestCase(0.0081, 4, 0.1, ExpectedResult =0.3)]
   - [TestCase(-0.008, 3, 0.1, ExpectedResult =-0.2)]
   - [TestCase(0.004241979, 9, 0.00000001, ExpectedResult =0.545)]
   - [TestCase(8, 15, -7, -5)] <- ArgumentOutOfRangeException
   - [TestCase(8, 15, -0.6, -0.1)] <- ArgumentOutOfRangeException	
   
   Рекомендованный шаблон для тестового метода проверки исключений.
   
   MethodName_Number_Degree_Precision_ArgumentOutOfRangeException(double number, int degree, double precision, double expected)
   {   
         Assert.Throws<ArgumentOutOfRangeException>(() => ClassName.MethodName(number, degree, precision));  
   }
2. Реализовать метод "пузырьковой" сортировки для целочисленного массива (не использовать методы класса System.Array) таким образом, чтобы была возможность упорядочить строки матрицы
   - в порядке возрастания(убывания) сумм элементов строк матрицы;
   - в порядке возрастания(убывания) максимальных элементов строк матрицы;
   - в порядке возрастания(убывания) минимальных элементов строк матрицы.
