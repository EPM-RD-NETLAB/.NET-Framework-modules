<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// TimeZoneInfo.Local returns the current local time zone:
TimeZoneInfo zone = TimeZoneInfo.Local;
zone.StandardName.Dump ("StandardName (local)");
zone.DaylightName.Dump ("DaylightName (local)");

// You can obtain a TimeZoneInfo for any of the world’s time zones by calling FindSystemTimeZoneById with the zone ID:
TimeZoneInfo wa = TimeZoneInfo.FindSystemTimeZoneById ("W. Australia Standard Time");

Console.WriteLine (wa.Id);                   // W. Australia Standard Time
Console.WriteLine (wa.DisplayName);          // (GMT+08:00) Perth
Console.WriteLine (wa.BaseUtcOffset);        // 08:00:00
Console.WriteLine (wa.SupportsDaylightSavingTime);     // True
Console.WriteLine();

// The following returns all world timezones:
foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
  Console.WriteLine (z.Id);
