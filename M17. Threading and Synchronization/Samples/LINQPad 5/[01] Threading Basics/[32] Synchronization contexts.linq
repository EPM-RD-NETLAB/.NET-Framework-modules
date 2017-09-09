<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\PresentationUI.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\wpf\WindowsBase.dll</Reference>
  <Namespace>System.Windows</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
</Query>

void Main()
{
	Util.CreateSynchronizationContext();
	new MyWindow().ShowDialog();
}

partial class MyWindow : Window
{
	TextBox txtMessage;
	SynchronizationContext _uiSyncContext;

	public MyWindow()
	{
		InitializeComponent();
		// Capture the synchronization context for the current UI thread:
		_uiSyncContext = SynchronizationContext.Current;
		new Thread (Work).Start();
	}
	
	void Work()
	{
		Thread.Sleep (5000);           // Simulate time-consuming task
		UpdateMessage ("The answer");
	}
	
	void UpdateMessage (string message)
	{
		// Marshal the delegate to the UI thread:
		_uiSyncContext.Post (_ => txtMessage.Text = message, null);
	}
	
	void InitializeComponent()
	{
		SizeToContent = SizeToContent.WidthAndHeight;
		WindowStartupLocation = WindowStartupLocation.CenterScreen;
		Content = txtMessage = new TextBox { Width=250, Margin=new Thickness (10), Text="Ready" };
	}
}
