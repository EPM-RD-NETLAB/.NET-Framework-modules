<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;System.Drawing.dll</Reference>
  <Namespace>System.Drawing</Namespace>
</Query>

// Maps to a Customer table in a database
public class Customer
{
  /*...*/
  public decimal? AccountBalance;	// Works well with SQL's nullable column
}

// Color is an ambient property:
public class Row
{
  /*...*/
  Grid parent;
  Color? color;

  public Color Color
  {
	get { return color ?? parent.Color; }
	set { color = Color == parent.Color ? (Color?)null : value; }
  }
}

class Grid
{
	/*...*/
	public Color Color { get; set; }
}

void Main() { }