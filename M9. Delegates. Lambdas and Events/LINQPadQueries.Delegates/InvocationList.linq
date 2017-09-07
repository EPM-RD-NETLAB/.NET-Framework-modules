<Query Kind="Program" />

void Main(string[] args)
{
	GetInvocationList.Go();
}

internal static class GetInvocationList
{
	internal sealed class Light
	{
		public string SwitchPosition() { return "The light is off"; }
	}

	internal sealed class Fan
	{
		public string Speed() { throw new InvalidOperationException("The fan broke due to overheating"); }
	}

	internal sealed class Speaker
	{
		public string Volume() { return "The volume is loud"; }
	}

	private delegate string GetStatus();

	public static void Go()
	{
		GetStatus getStatus = null;
		getStatus += new Light().SwitchPosition;
		getStatus += new Fan().Speed;
		getStatus += new Speaker().Volume;
		//getStatus();
		Console.WriteLine(GetComponentStatusReport(getStatus));
	}

	private static string GetComponentStatusReport(GetStatus status)
	{
		if (status == null) return null;

		//status();

		var report = new StringBuilder();

		Delegate[] arrayOfDelegates = status.GetInvocationList();

		foreach (GetStatus getStatus in arrayOfDelegates)
		{
			try
			{
				report.AppendFormat("{0}{1}{1}", getStatus(), Environment.NewLine);
			}
			catch (InvalidOperationException e)
			{
				Object component = getStatus.Target;
				report.AppendFormat(
				   "Failed to get status from {1}{2}{0}   Error: {3}{0}{0}",
				   Environment.NewLine,
				   ((component == null) ? string.Empty : component.GetType() + "."),
				   getStatus.Method.Name, e.Message);
			}
		}

		return report.ToString();
	}
}