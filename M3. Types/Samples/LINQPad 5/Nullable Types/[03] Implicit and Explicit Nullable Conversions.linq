<Query Kind="Statements" />

// The conversion from T to T? is implicit, and from T? to T is explicit:

int? x = 5;        // implicit
int y = (int)x;    // explicit
