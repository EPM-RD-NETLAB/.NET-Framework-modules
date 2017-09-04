<Query Kind="Statements" />

// Some types define < and > operators:
bool after2010 = DateTime.Now > new DateTime (2010, 1, 1);

// The string type doesn't overload these operators (for good reason):
bool error = "Beck" > "Anne";       // Compile-time error