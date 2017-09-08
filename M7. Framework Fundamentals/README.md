## Material Content 
- *String and Text Handling (String, StringBuilder).*
- *Formatting and Parsing.*
- *Dates and Times.*
- *Equality Comparison - Standard Equality Protocols.*
- *Order Comparison.*
- *IComparable versus Equals.*

## Books & Useful References 
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 6.* Framework Fundamentals. [Code Listing](http://www.albahari.com/nutshell/ch06.aspx)
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 14.* Chars, Strings, and Working with Text.

## Presentation 
- Framework Fundamentals (ENG) (***in progress***)

## Samples 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M7.%20Framework%20Fundamentals/Samples/LINQPad)

## Tasks  
**Objective:** 
- *learning class System.String and standard formattable and pluggable formattable protocols, as a implementation Stategy Pattern.* 

1. Customer class has three public properties - Name (string), ContactPhone (string) and Revenue (decimal). Implement for the Customer's objects the opportunity of a various string representation. For example, the object with the Name = "Jeffrey Richter", Revenue = 1000000, ContactPhone = "+1 (425) 555-0100" can have the following string representation:
- Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100
- Customer record: +1 (425) 555-0100
- Customer record: Jeffrey Richter, 1,000,000.00
- Customer record: Jeffrey Richter
- Customer record: 1000000, etc. 
Add to Customer class an additional formatting opportunity, that is not provided by the class (Customer class do not change). Develop unit tests.
