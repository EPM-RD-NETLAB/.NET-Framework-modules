## Material Content 
- *Encapsulation. Access modifiers. Properties. Automatic properties. Indexers.*
- *Inheritance.*
- *Sealed Methods and Classes.*
- *Special Base Types - System.ValueType, System.Enum.*
- *Virtual methods.*
- *System. Object (Equals, GetHashCode, ToString and etc).*
- *Abstract methods.*
- *Abstract classes.*
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
**Objective:** 
- *understanding the difference between overload and overriding;*
- *modeling the relationship "can do" by the ICloneable and IEquatable interfaces;*
- *using dependency injection in the method technique;*
- *correct using of inheritancies;*
- *writing flexible extensible code;*
- *design pattern Visitor preview.*
1. To refactor the algorithm [Task 2 Module 3](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M3.%20Types) (delegates and standard interfaces do not use), allowing to sorting both in ascending and descending, depending on comparison criterion of the matrix rows. Develop unit-tests using varioгs comparison criterion of the matrix rows.
2. Develop a geometric shapes class hierarchy - Circle, Triangle, Square, Rectangle. Classes should describe the properties of a shape and have methods for calculating the area and perimeter of the shape. (*A task with an emphasis on building an inheritance hierarchy, without unduly detailed implementation*).
3. Create Polynomial class for working with polynomials of degree n > 0 of one real variable (as an internal structure for storing coefficients use the sz-array). Override the necessary methods of the System.Object Type and also overload base operations for working with polynomials. Develop unit-tests.
