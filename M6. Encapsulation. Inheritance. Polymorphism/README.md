## Material Content 
- *Encapsulation. Access modifiers. Properties. Automatic properties. Indexers.*
- *Inheritance.*
- *Sealed Methods and Classes.*
- *Special Base Types - System.ValueType, System.Enum.*
- *Virtual methods.*
- *System. Object (Equals, GetHashCode, ToString and etc).*
- *Abstract methods.*
- *Abstruct classes.*
- *Interface Inheritance.*
- *Dynamic.*
- *Single dispatch and multiple dispatch.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do)
  - *Chapter 6.* Inheritance ([Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch06.zip))
  - *Chapter 14.* Dynamic Typing ([Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch14.zip))
- [C# 4.0 Unleashed. Bart De Smet. Sams Publishing. 2011](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 11.* Fields, Properties, and Indexers
   - *Chapter 14.* Object-Oriented Programming
   - *Chapter 22.* Dynamic Programming .
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 10.* Properties
   - *Chapter 13.* Interfaces

## Presentation 
- [Encapsulation. Inheritance. Polymorphism (ENG)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M6.%20Encapsulation.%20Inheritance.%20Polymorphism/Encapsulation.%20Inheritance.%20Polymorphism.pptx)
- [Encapsulation. Inheritance. Polymorphism (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M6.%20Encapsulation.%20Inheritance.%20Polymorphism/Encapsulation.%20Inheritance.%20Polymorphism%20(ru).pptx)

## Samples 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M6.%20Encapsulation.%20Inheritance.%20Polymorphism/Samples/LINQPad)

## Tasks  
**Objective:** *To understand the difference between overload and redefinition,modeling the relationship to can do using the ICloneable and IEquatable interfaces, using dependency injection in the method, correct use of inheritance, writing flexible extensible code, familiarity with the design pattern of the visitor.*
1. Perform refactoring (delegates do not use) the algorithm for sorting rows of a nonrectangular integer matrix [Task 2 Module 3](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M3.%20Types), allowing to perform sorting, both in ascending and descending, depending on the matrix rows sent to the method of comparison (standard interfaces do not use). Develop unit-tests using the string comparison criteria listed in.
2. Develop a class hierarchy for describing geometric shapes - Circles, Triangles, Squares, Rectangles. Classes must describe the properties of a shape and have methods for calculating the area and perimeter of the shape. (A task with an emphasis on building an inheritance hierarchy, without unduly detailed implementation).
3. Create class Polynomial for working with polynomials of degree n > 0 from one variable of real type (use the sz-array as an internal structure for storing coefficients). Override the necessary methods of the Object Type and also overload base operations for working with polynomials. Develop unit-tests.
