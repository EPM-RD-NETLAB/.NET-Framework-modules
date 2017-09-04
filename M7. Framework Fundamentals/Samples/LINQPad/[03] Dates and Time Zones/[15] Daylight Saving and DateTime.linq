<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The IsDaylightSavingTime tells you whether a given local DateTime is subject to daylight saving.
Console.WriteLine (DateTime.Now.IsDaylightSavingTime());     // True or False

// UTC times always return false:
Console.WriteLine (DateTime.UtcNow.IsDaylightSavingTime());  // Always False

// The end of daylight saving presents a particular complication for algorithms that use local time.
// The comments on the right show the results of running this in a daylight-saving-enabled zone:
DaylightTime changes = TimeZone.CurrentTimeZone.GetDaylightChanges (2010);
TimeSpan halfDelta = new TimeSpan (changes.Delta.Ticks / 2);
DateTime utc1 = changes.End.ToUniversalTime() - halfDelta;
DateTime utc2 = utc1 - changes.Delta;

// Converting these variables to local times demonstrates why you should use UTC and not local time
// if your code relies on time moving forward:
DateTime loc1 = utc1.ToLocalTime();  // (Pacific Standard Time)
DateTime loc2 = utc2.ToLocalTime();
Console.WriteLine (loc1);            // 2/11/2010 1:30:00 AM
Console.WriteLine (loc2);            // 2/11/2010 1:30:00 AM
Console.WriteLine (loc1 == loc2);    // True

// Despite loc1 and loc2 reporting as equal, they are different inside:
Console.WriteLine (loc1.ToString ("o"));  // 2010-11-02T02:30:00.0000000-08:00
Console.WriteLine (loc2.ToString ("o"));  // 2010-11-02T02:30:00.0000000-07:00

// The extra bit ensures correct round-tripping between local and UTC times:
Console.WriteLine (loc1.ToUniversalTime() == utc1);   // True
Console.WriteLine (loc2.ToUniversalTime() == utc2);   // True