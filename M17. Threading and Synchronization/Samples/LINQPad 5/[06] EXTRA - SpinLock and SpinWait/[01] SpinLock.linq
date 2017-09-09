<Query Kind="Statements" />

// See http://www.albahari.com/threading/part5.aspx for the accompanying text on SpinLock and SpinWait

var spinLock = new SpinLock (true);   // Enable owner tracking
bool lockTaken = false;
try
{
	spinLock.Enter (ref lockTaken);
	// Do stuff...
}
finally
{
	if (lockTaken) spinLock.Exit();
}