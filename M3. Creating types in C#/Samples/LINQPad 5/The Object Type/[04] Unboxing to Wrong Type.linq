<Query Kind="Statements" />

// When unboxing, the types must match exactly:

object obj = 9;           // 9 is inferred to be of type int
long x = (long) obj;      // InvalidCastException