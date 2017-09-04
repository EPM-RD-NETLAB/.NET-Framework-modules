## Material Content 
- *String and Text Handling (String, StringBuilder).*
- *Formatting and Parsing.*
- *Dates and Times.*
- *Equality Comparison - Standard Equality Protocols.*
- *Order Comparison.*
- *IComparable versus Equals.*

## Books & Useful References 
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 6.* Framework Fundamentals ([Example Code](http://www.albahari.com/nutshell/ch06.aspx))
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 14.* Chars, Strings, and Working with Text

## Presentation 
- [Framework Fundamentals (ENG)] (*in progress*)

## Samples 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M7.%20Framework%20Fundamentals/Samples/LINQPad)

## Tasks  
**Objective:** *TODO* 
1. Customer class has public properties - Name (string), ContactPhone (string) and Revenue (decimal). Implement for the objects of class Customer the possibility of a various string representation. For example, for the object with the values Name = "Jeffrey Richter", Revenue = 1000000, ContactPhone = "+1 (425) 555-0100", string representation:
- Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100
- Customer record: +1 (425) 555-0100
- Customer record: Jeffrey Richter, 1,000,000.00
- Customer record: Jeffrey Richter
- Customer record: 1000000, etc. 
Add an additional formatting capability for objects of this class that is not provided by the class (Customer class do not change). Develop unit tests.
