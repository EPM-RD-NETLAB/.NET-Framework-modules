<Query Kind="Statements" />

// The contextual keyword var implicitly types local variables:
{
	var x = "hello";
	var y = new System.Text.StringBuilder();
	var z = (float)Math.PI;
}

// This is precisely equivalent to:
{
	string x = "hello";
	System.Text.StringBuilder y = new System.Text.StringBuilder();
	float z = (float)Math.PI;
}