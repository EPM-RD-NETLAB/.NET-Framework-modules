<Query Kind="Statements">
  
</Query>

var tune = new LinkedList<string>();
tune.AddFirst ("do");                           tune.Dump(); // do
tune.AddLast ("so");                            tune.Dump(); // do - so

tune.AddAfter (tune.First, "re");               tune.Dump(); // do - re- so
tune.AddAfter (tune.First.Next, "mi");          tune.Dump(); // do - re - mi- so
tune.AddBefore (tune.Last, "fa");               tune.Dump(); // do - re - mi - fa- so

tune.RemoveFirst();                             tune.Dump(); // re - mi - fa - so
tune.RemoveLast();                              tune.Dump(); // re - mi - fa

LinkedListNode<string> miNode = tune.Find ("mi");
tune.Remove (miNode);                           tune.Dump(); // re - fa
tune.AddFirst (miNode);                         tune.Dump(); // mi- re - fa

