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
- [StyleCop](https://github.com/StyleCop)

## Презентации 
- Basic Coding in C# (ENG)
- [Basic Coding in C# (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M2.%20Basic%20Coding%20in%20C%23/Basic%20Coding%20in%20C%23.pptx)

## Примеры 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M2.%20Basic%20Coding%20in%20C%23/Samples/LINQPad%205)

## Задачи  
**Цели:** 
- *изучить классы System.Array и System.String;* 
- *изучить алгоритмы поиска и сортировки.*

1. Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода. (Ниже пояснение к алгоритму).
![Схема к алгоритму](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M2.%20Basic%20Coding%20in%20C%23/Scheme.png)
2. Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
3. Given an array of integers. Find and return an index n for which the sum of the elements to the left of it is equal to the sum of the elements on the right. If such an index does not return null (or -1).
4. Two strings include only characters from 'a' to 'z', return a concatenated alphabetized string, excluding duplicate characters.
5. Write a method FilterLucky that accepts a list of integers and filters the list to only include the elements that contain the digit 7. For example,  FilterLucky(1,2,3,4,5,6,7,68,69,70,15,17) --> { 7, 70, 17 }.
