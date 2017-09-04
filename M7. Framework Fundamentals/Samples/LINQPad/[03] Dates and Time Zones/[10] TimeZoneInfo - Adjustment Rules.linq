<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	// Western Australia's daylight saving rules are interesting, having introduced daylight
	// saving midseason in 2006 (and then subsequently rescinding it):
	
	TimeZoneInfo wa = TimeZoneInfo.FindSystemTimeZoneById ("W. Australia Standard Time");
	
	foreach (TimeZoneInfo.AdjustmentRule rule in wa.GetAdjustmentRules())
		Console.WriteLine ("Rule: applies from " + rule.DateStart +
										  " to " + rule.DateEnd);
	
	foreach (TimeZoneInfo.AdjustmentRule rule in wa.GetAdjustmentRules())
	{
		Console.WriteLine();
		Console.WriteLine ("Rule: applies from " + rule.DateStart + " to " + rule.DateEnd);
		Console.WriteLine ("   Delta: " + rule.DaylightDelta);
		Console.WriteLine ("   Start: " + FormatTransitionTime (rule.DaylightTransitionStart, false));
		Console.WriteLine ("   End:   " + FormatTransitionTime (rule.DaylightTransitionEnd, true));
	}
}

static string FormatTransitionTime (TimeZoneInfo.TransitionTime tt,
									bool endTime)
{
	if (endTime && tt.IsFixedDateRule
				&& tt.Day == 1 && tt.Month == 1
				&& tt.TimeOfDay == DateTime.MinValue)
		return "-";
	
	string s;
	if (tt.IsFixedDateRule)
		s = tt.Day.ToString();
	else
		s = "The " +
			"first second third fourth last".Split() [tt.Week - 1] +
			" " + tt.DayOfWeek + " in";
	
	return s + " " + DateTimeFormatInfo.CurrentInfo.MonthNames [tt.Month-1]
			 + " at " + tt.TimeOfDay.TimeOfDay;
}