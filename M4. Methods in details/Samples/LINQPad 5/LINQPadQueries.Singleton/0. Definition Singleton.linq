<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

#region Advanced
//http://csharpindepth.com/Articles/General/Singleton.aspx
#endregion

#region Definition
/*
The singleton pattern is one of the best-known patterns in software engineering. 
Essentially, a singleton is a class which only allows a single instance of itself
to be created, and usually gives simple access to that instance. 

Most commonly, singletons don't allow any parameters to be specified when 
creating the instance - as otherwise a second request for an instance but 
with a different parameter could be problematic!

There are various different ways of implementing the singleton pattern in C#. 
I shall present them here in reverse order of elegance, starting with the most 
commonly seen, which is not thread-safe, and working up to a fully lazily-loaded,
thread-safe, simple and highly performant version.

All these implementations share four common characteristics:
1. A single constructor, which is private and parameterless.
2. The class is sealed. (This is unnecessary, but may help the JIT to optimise things more)
3. A static variable which holds a reference to the single created instance, if any.
4. A public static means of getting the reference to the single created instance, 
creating one if necessary

Note that all of these implementations also use a public static property Instance as the means
of accessing the instance. In all cases, the property could easily be converted to a method, 
with no impact on thread-safety or performance.
*/
#endregion