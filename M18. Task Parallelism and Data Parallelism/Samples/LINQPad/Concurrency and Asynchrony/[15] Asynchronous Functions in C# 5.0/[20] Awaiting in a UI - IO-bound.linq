<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\UIAutomationProvider.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationUI.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\System.Printing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\ReachFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\UIAutomationTypes.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{
	new TestUI().ShowDialog();
}

class TestUI : Window		// Notice how the window becomes unresponsive while working
{
	Button _button = new Button { Content = "Go" };
	TextBlock _results = new TextBlock();
		
	public TestUI()
	{
		var panel = new StackPanel();
		panel.Children.Add (_button);
		panel.Children.Add (_results);
		Content = panel;
		_button.Click += (sender, args) => Go();
	}
		
	async void Go()
	{
		_button.IsEnabled = false;
		string[] urls = "www.albahari.com www.oreilly.com www.linqpad.net".Split();
		int totalLength = 0;
		try
		{
			foreach (string url in urls)
			{
				var uri = new Uri ("http://" + url);
				byte[] data = await new WebClient().DownloadDataTaskAsync (uri);
				_results.Text += "Length of " + url + " is " + data.Length + Environment.NewLine;
				totalLength += data.Length;
			}
			_results.Text += "Total length: " + totalLength;
		}
		catch (WebException ex)
		{
			_results.Text += "Error: " + ex.Message;
		}
		finally { _button.IsEnabled = true; }
	}
		
	Task<int> GetPrimesCountAsync (int start, int count)
	{
		return Task.Run (() =>
			ParallelEnumerable.Range (start, count).Count (n => 
				Enumerable.Range (2, (int) Math.Sqrt(n)-1).All (i => n % i > 0)));
	}
}
