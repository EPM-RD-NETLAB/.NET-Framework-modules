<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\WindowsBase.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
  <Namespace>System.Windows.Threading</Namespace>
</Query>

void Main()
{
	new MyWindow().ShowDialog();	
}

public partial class MyWindow : System.Windows.Window
{
	Label lblResult = new Label();
	TaskScheduler _uiScheduler;   // Declare this as a field so we can use
								  // it throughout our class.
	public MyWindow()
	{    
		InitializeComponent();		
	}
	
	protected override void OnActivated (EventArgs e)
	{
		// Get the UI scheduler for the thread that created the form:
		_uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
	
		Task.Factory.StartNew<string> (SomeComplexWebService)
			.ContinueWith (ant => lblResult.Content = ant.Result, _uiScheduler);		
	}
	
	void InitializeComponent()
	{
		lblResult.FontSize = 20;
		Content = lblResult;
	}
	
	string SomeComplexWebService() { Thread.Sleep (1000); return "Foo"; }
}