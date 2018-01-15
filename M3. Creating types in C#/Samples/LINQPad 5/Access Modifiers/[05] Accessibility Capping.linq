<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;System.Windows.Forms.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

// A type caps the accessibility of its declared members:

class C						// Class C is implicitly internal
{
	public void Foo() {}	// Foo's accessibility is capped at internal
}

static void Main() { }
