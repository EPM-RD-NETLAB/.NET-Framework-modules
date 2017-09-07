<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Func<TResult>, Func<T, TResult> ... - делегат
//
//public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(
//	T1 arg1,
//	T2 arg2,
//	T3 arg3,
//	T4 arg4,
//	T5 arg5,
//	T6 arg6,
//	T7 arg7,
//	T8 arg8,
//	T9 arg9,
//	T10 arg10,
//	T11 arg11,
//	T12 arg12,
//	T13 arg13,
//	T14 arg14,
//	T15 arg15,
//	T16 arg16
//)
//
//Action, Action<T> ... - делегат

//public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(
//	T1 arg1,
//	T2 arg2,
//	T3 arg3,
//	T4 arg4,
//	T5 arg5,
//	T6 arg6,
//	T7 arg7,
//	T8 arg8,
//	T9 arg9,
//	T10 arg10,
//	T11 arg11,
//	T12 arg12,
//	T13 arg13,
//	T14 arg14,
//	T15 arg15,
//	T16 arg16
//)

Action<string, int> myDelegate = null;
myDelegate += ((param1, param2) =>
              {
                   Console.WriteLine("{0} : {1}", param1, param2.ToString());
              });
if (myDelegate != null)
{
    myDelegate("Value", 5);
}

Func<string, int, string> myDelegate = null;
myDelegate += ((param1, param2) =>
              {
                  return String.Format("{0} : {1}", param1, param2.ToString());
              });
if (myDelegate != null)
{
     string returnedValue;
     returnedValue = myDelegate("Value", 5);
     Console.WriteLine(returnedValue);
}
