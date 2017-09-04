<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

// If a member fails to bind, a RuntimeBinderException is thrown. This can be
// thought of like a compile-time error at runtime:

dynamic d = 5;
d.Hello();                  // throws RuntimeBinderException