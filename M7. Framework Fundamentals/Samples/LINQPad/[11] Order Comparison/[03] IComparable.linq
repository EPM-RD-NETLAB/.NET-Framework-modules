<Query Kind="Statements" />

// The IComparable interfaces are defined as follows:
//   public interface IComparable       { int CompareTo (object other); }
//   public interface IComparable<in T> { int CompareTo (T other);      }

Console.WriteLine ("Beck".CompareTo ("Anne"));       // 1
Console.WriteLine ("Beck".CompareTo ("Beck"));       // 0
Console.WriteLine ("Beck".CompareTo ("Chris"));      // -1
