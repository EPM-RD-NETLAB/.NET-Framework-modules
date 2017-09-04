<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The static TimeZone.CurrentTimeZone method returns a TimeZone object based on the current local settings.
TimeZone zone = TimeZone.CurrentTimeZone;
zone.StandardName.Dump ("StandardName");
zone.DaylightName.Dump ("DaylightName");

// The IsDaylightSavingTime and GetUtcOffset methods work as follows:
DateTime dt1 = new DateTime (2008, 1, 1);
DateTime dt2 = new DateTime (2008, 6, 1);
zone.IsDaylightSavingTime (dt1).Dump ("IsDaylightSavingTime (January)");
zone.IsDaylightSavingTime (dt2).Dump ("IsDaylightSavingTime (June)");
zone.GetUtcOffset (dt1).Dump ("UTC Offset (January)");
zone.GetUtcOffset (dt2).Dump ("UTC Offset (June)");

// The GetDaylightChanges method returns specific daylight saving information for a given year:
DaylightTime day = zone.GetDaylightChanges (2010);
if (day == null) return;
day.Start.Dump ("day.Start");
day.End.Dump ("day.End");
day.Delta.Dump ("day.Delta");