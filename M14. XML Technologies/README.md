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
- *study base XML technologies;*
- *study architecture based on interfaces;*
- *write adaptive code.*
1. Develop parallel XML parser to analysis a large number of xml files. Implement it as class library (set of classes and intrfaces) with following features
   - select a node in all files based on a specified XPath  expression;
   - calculate number of occurrences of each different value of this node.

The required number of concurrent threads, xpath expression and xml files folder recommended to be configured (file app.config by default). 

Consider following situations:
 - When the number of files and the size of a file is very huge (i.e  1GB) - XML parser still needs to work stable.
 - When the xml file is not "Well Formed" - log the exception that occurred (use for instance – NLog or log4net or any other).

Samples of the XML files that the parser can process are in the archive [xml.7z](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies/Data).
 
 *Input: (Read the input parameters from a configuration file.)*
 1) Path to the folder with XML files to be processed.
 2) XPath expression pointing to a node in XML.
 3) Number of concurrent threads.
 
 *Output:*  Sorted list of all different values that this node has with number of occurrences of each value, sorted by number of occurrences, descending. If a node is missing in a certain XML it should be considered as having "N/A" value.

 **Example 1.**

**Input: (XML files: File1.xml, File2.xml, File3.xml) and XPath = "docID"**

*File1.xml:*

<?xml version="1.0" encoding="UTF-8"?>
<docSearch_dsReq_0_0 xmlns="x-schema:mxschema://docsearch" maxRows="1" exclude3rdParty="0" synCharsRequired="0" acceptLanguage="en" ppv="both" calcPrice="1" tkrEncoding="prtID" infoLevel="default" dateRange="allDates" queryType="normal" companyID="222" userID="798955">
   <docID>34387618</docID>
   <sort s_d="desc" s_c="score"/>
   <excludeCtbs>0</excludeCtbs>
</docSearch_dsReq_0_0>

*File2.xml:*

<?xml version="1.0" encoding="UTF-8"?>
<docSearch_dsReq_0_0 xmlns="x-schema:mxschema://docsearch" maxRows="3" exclude3rdParty="1" synCharsRequired="0" acceptLanguage="en" calcPrice="0" tkrPrimary="1" tkrEncoding="prtID" dateRange="last90Days" queryType="normal" companyID="25256" userID="3118158">
   <sort s_d="desc" s_c="date"/>
   <excludeCtbs>0</excludeCtbs>
   <ctbs>54,767,2,5179,3202,3414,16006,360,25256</ctbs>
   <ticker>100204446</ticker>
   <analystSet>MX#001</analystSet>
   <industrySet>MX#001</industrySet>
   <subjectSet>MX#001</subjectSet>
   <regionSet>MX#001</regionSet>
   <categorySet>MX#001</categorySet>
   <langID>en</langID>
   <matchStr strSrc="hdln">"model"</matchStr>
</docSearch_dsReq_0_0>

*File3.xml:*
<?xml version="1.0"?>
<docSearch_dsReq_0_0 xmlns="http://www.schemas.multex.com/docsearch" userID="2112" companyID="184" dateRange="allDates" calcPrice="1" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <sort s_c="date"/>
   <excludeCtbs>false</excludeCtbs>
   <ctbs>17846</ctbs>
   <industrySet>MG#10338</industrySet>
   <industry>0606</industry>
   <industry>0609</industry>
   <industry>0612</industry>
   <industry>0133</industry>
   <industry>0909</industry>
   <industry>1209</industry>
   <subjectSet>MX#001</subjectSet>
   <subject>OVER</subject>
   <subject>NOV</subject>
</docSearch_dsReq_0_0>

**Output:**

   * N/A  2 
   * 234387618  1

 **Example 2.**
 
 **Input: (XML files: File1.xml, File2.xml, File3.xml in example 1) and XPath = "sort/@s_c"**
 
 **Output:**

   * date 2 
   * score 1
