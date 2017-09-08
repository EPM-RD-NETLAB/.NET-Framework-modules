## Material Content 
- *Generic types.*
- *Type constraints: reference type,  value type, new(),  type inference and etc.*
- *Enumeration:  IEnumerable, IEnumerator, IEnumerable(T) and IEnumerator(T) .*
- *IEqualityComparer and EqualityComparer.*
- *Block iterator yield.*
- *IStructuralEquatable and IStructuralComparable.*
- *ICollection, IList and IDictionary<TKey,TValue> Interfaces.*
- *Lists, Queues, Stacks, Sets and Dictionaries.*
- *Customizable Collections and Proxies.*

## Books & Useful References 
- [Programming C# 5.0. Ian Griffiths. O'Reilly Media. 2012.](http://shop.oreilly.com/product/0636920024064.do) 
   - *Chapter 4.* Generics. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch04.zip) 
   - *Chapter 5.* Collections. [Download Example Code](https://resources.oreilly.com/examples/0636920024064/blob/master/Ch05.zip)
- [C# in Depth. Jon Skeet. Manning Publications Co. 2013](https://www.manning.com/books/c-sharp-in-depth-third-edition)
   - *Chapter 3.* [Parameterized typing with generics.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/chapter-3/)
   - *Appendix B.* [Generic collections in .NET.](https://livebook.manning.com/#!/book/c-sharp-in-depth-third-edition/appendix-b/)
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 7.* Collections. [Code Listings](http://www.albahari.com/nutshell/ch07.aspx)
- [C# 5.0 Unleashed. Bart De Smet. Sams Publishing. 2013](https://www.goodreads.com/book/show/16284093-c-5-0-unleashed)
   - *Chapter 15.* Generic Types and Methods.
   - *Chapter 16.* Collection Types.
- [CLR via C#. Jeffrey Richter. Microsoft Press. 2010](https://www.goodreads.com/book/show/7121415-clr-via-c)
   - *Chapter 12.* Generics.
- [Pro .NET Performance: Optimize Your C# Applications. Sasha Goldshtein.](http://www.apress.com/us/book/9781430244585)
   - *Chapter 5.* Collections and Generics
   
## Presentation 
- Generics and Collections (ENG)
- [Generics and Collections (RU)](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M10.%20Generics%20and%20Collections/Generics%20and%20Collections.pptx)

## Samples 
[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M10.%20Generics%20and%20Collections/Samples/LINQPad%205)

## Tasks  
**Objective:** 
- *understand generic approach in the development;*
- *understand difference between typed and not typed generic types;*
- *understand IEnumerable, IEnumerator, IEnumerable(T) and IEnumerator(T) interfaces;*
- *understand plugging in equality and order;*
- *understand foreach loop;*
- *understand block iterator yield.*

1. Implement a BinarySearch generic method (*do not use the type constraints*). Develop unit-tests.
2. The test file contains some information. Implement an algorithm that allows to determine the frequency of occurrences of words in the text. Develop unit-tests.
3. Implement a method for the counting of the Fibonacci's numbers of the Fibonacci using the iterator block yield. Develop unit-tests.
4. Develop a generic class-collection Queue that implements the basic operations for working with the stucture data queue. Implement the capability to iterate by collection by design pattern Iterator. Develop unit-tests.
5. Develop a generic class-collection Stack that implements the basic operations for working with the stucture data stack. Implement the capability to iterate by collection by design pattern Iterator. Develop unit-tests.
6. Develop a generic class-collection Set that implements the basic operations for working with the stucture data set with the reference types elements. Implement the capability to iterate by collection by block iterator yield. Develop unit-tests.
7. Develop a generic class-collection BinarySearchTree that implements the basic operations for working with the stucture data binary search tree. Provide an opportunity of using a plug-in interface to implement the order relation. Implement three ways of traversing the tree: direct (preorder), transverse (inorder), reverse (postorder) (use the block iterator yield). Develop unit-tests. Use for the testiong the following types:
   - System.String (use default comparison and plug-in comparator);
   - the custom class Book, for objects of which the order relation is implemented (use the default comparison and plug-in comparator);
   - the custom structure Point, for instance of which the relation of order is not implemented (use a plug-in comparator).
