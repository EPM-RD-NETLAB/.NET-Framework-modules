## Material Content 

- *XML intro.*
- *Architectural Overview.*
- *X-DOM Overview.*
- *The LINQ to XML DOM. Instantiating an X-DOM.*
- *Navigating and Querying. Updating an X-DOM.*
- *Documents and Declarations.*
- *Projecting into an X-DOM.*
- *XmlReader. XmlWriter.*
- *Patterns for Using XmlReader/XmlWriter.*
- *XSD and Schema Validation. XSLTXSD, XSLT, XPath.*

#### Books & Useful References 

- [XML Tutorial](https://www.w3schools.com/xml/)
- [XML Tutorial](https://www.tutorialspoint.com/xml/)
- [C# 6.0 in a Nutshell. Joseph Albahari, Ben Albahari. O'Reilly Media. 2015.](http://shop.oreilly.com/product/0636920040323.do)
   - *Chapter 10.* LINQ to XML [Code Listings](http://www.albahari.com/nutshell/ch10.aspx)
   - *Chapter 11.* Other XML Technologies [Code Listings](http://www.albahari.com/nutshell/cs4ch11.aspx)

## Presentations 

- XML Technologies (ENG)

## Samples

[LINQPad 5](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Samples/LINQPad/XML%20Technologies)

## Tasks  
**Objective:** 
- *study .NET Framework APIs for working with XML data;*
- *study architecture based on interfaces;*
- *write adaptive code.*

Develop concurrent XML parser to analysis a large number of xml files. Implement it as class library (set of classes and intrfaces) with following features
   - select a node in all files based on a specified XPath  expression;
   - calculate number of occurrences of each different value of this node.

The required number of concurrent threads, xpath expression and xml files folder recommended to be configured (file app.config by default). 

Consider following situations:
 - When the number of files and the size of a file is very huge (i.e  1GB) - XML parser still needs to work stable.
 - When the xml file is not "Well Formed" - log the exception that occurred (use for instance – NLog or log4net or any other).

Develop unit tests for the constructed class library.

Develop console applicatin for workinп with the constructed class library. 

Samples of the XML files that the parser can process are in the archive [xml.7z](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Data).
 
 *Input: (Read the input parameters from a configuration file.)*
 1) Path to the folder with XML files to be processed.
 2) XPath expression pointing to a node in XML.
 3) Number of concurrent threads.
 
 *Output:*  Sorted list of all different values that this node has with number of occurrences of each value, sorted by number of occurrences, descending. If a node is missing in a certain XML it should be considered as having "N/A" value.

 **Example 1.**

**Input: (XML files: File1.xml, File2.xml, File3.xml) and XPath = "docID"**

*File1.xml:*[here](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Data)

*File2.xml:*[here](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Data)

*File3.xml:*[here](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Data)

**Output:**

   * N/A, 2 
   * 34387618, 1

 **Example 2.**
 
 **Input: (XML files: File1.xml, File2.xml, File3.xml in example 1) and XPath = "sort/@s_c"**
 
 **Output:**

   * date, 2 
   * score, 1
