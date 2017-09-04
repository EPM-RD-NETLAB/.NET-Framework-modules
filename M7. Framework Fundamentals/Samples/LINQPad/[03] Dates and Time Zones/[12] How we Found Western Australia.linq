<Query Kind="Expression">
  <Namespace>System.Globalization</Namespace>
</Query>

// Western Australia is unique in having both fixed and floating rules. Here's how we found it:

from zone in TimeZoneInfo.GetSystemTimeZones()
let rules = zone.GetAdjustmentRules()
where
	rules.Any (r => r.DaylightTransitionEnd.IsFixedDateRule) &&
	rules.Any (r => !r.DaylightTransitionEnd.IsFixedDateRule)
select zone

// See Chapter 8 for info on writing LINQ queries.