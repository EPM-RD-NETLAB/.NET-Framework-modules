## Material Content 
- *Delegate types.*
- *Creating a delegate.*
- *Multicast delegates.*
- *Invoking a delegate.*
- *Common delegate types.*
- *Inline methods (anonymous function and  lambda expression).*
- *Delegates versus interfaces.*
- *Captured variables.*
- *Events. Standard event delegate pattern. Custom add and remove methods.*
- *Events versus delegates.*
- *Lambdas and expression trees.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do) 
    - *Chapter 9.* Delegates, Lambdas and Events. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch09.zip)
- [C# in Depth. Jon Skeet. Manning Publications Co. 2013](https://www.manning.com/books/c-sharp-in-depth-third-edition)
   - *Chapter 5.* [Fast-tracked delegates.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/chapter-5/)
   - *Chapter 9.* [Lambda expressions and expression trees.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/chapter-9/)
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 17.* Delegates.
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 17.* Delegates.

## Presentation 
- [Delegates. Lambdas and Events (ENG)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M9.%20Delegates.%20Lambdas%20and%20Events/Delegates.%20Lambdas%20and%20Events.pptx)
- [Delegates. Lambdas and Events (RU)]()

## Samples 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M9.%20Delegates.%20Lambdas%20and%20Events/LINQPadQueries.Delegates)

## Tasks  
**Objective:** 
- *understand delegate usage scenarios;*
- *understand the relationship delegates versus interfaces;*
- *understand callback functions;*
- *study design pattern Observer;*
- *understand difference between events and delegates;*
- *understand DRY (Don’t Repeat Yourself), SoC (Separation of Concerns principles), Low Coupling principles;*
- *write agile extensible testable code;*
- *understand standard event delegate pattern.*

1. Refactor of class methods [Task 2 Module 4](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M4.%20Methods%20in%20details) using delegates (the API's of the class should not change). 
2. Add to the class [Task 2 Module 3](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M3.%20Types) new methods with custom delegete, allowing to sorting both in ascending and descending, depending on comparison criterion of the matrix rows. Develop unit-tests using various comparison criterion of the matrix rows. 
3. Develop a Countdown class, which implements the capability after the appointed time (waiting time is provided by the user) to transmit a message to any subscriber who subscribes to the event. You can use the Thread.Sleep method to create a wait effect. Provide the possibility of subscribing to an event in several classes. Use the console application for testing.
