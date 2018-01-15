<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;System.Windows.Forms.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

// When overriding a base class function, accessibility must be identical on the overridden function:

class BaseClass             { protected virtual  void Foo() {} }
class Subclass1 : BaseClass { protected override void Foo() {} }  // OK
class Subclass2 : BaseClass { public    override void Foo() {} }  // Error

// A subclass itself can be less accessible than a base class, but not more:

internal class A { }
public class B : A { }          // Error

static void Main() { }
