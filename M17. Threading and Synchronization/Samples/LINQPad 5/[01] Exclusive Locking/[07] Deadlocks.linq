<Query Kind="Statements" />

object locker1 = new object();
object locker2 = new object();

new Thread (() => {
					lock (locker1)
					{
					  Thread.Sleep (1000);
					  lock (locker2) { }      // Deadlock
					}
				  }).Start();
lock (locker2)
{
  Thread.Sleep (1000);
  lock (locker1) { }                          // Deadlock
}
