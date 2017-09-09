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
	new MyWindow().ShowDialog();
}

partial class MyWindow : Window
{
	TextBox txtMessage;
	
	public MyWindow()
	{
		InitializeComponent();
		new Thread (Work).Start();
	}
	
	void Work()
	{
		Thread.Sleep (5000);           // Simulate time-consuming task
		UpdateMessage ("The answer");
	}
	
	void UpdateMessage (string message)
	{
		Action action = () => txtMessage.Text = message;
		Dispatcher.BeginInvoke (action);
	}
	
	void InitializeComponent()
	{
		SizeToContent = SizeToContent.WidthAndHeight;
		WindowStartupLocation = WindowStartupLocation.CenterScreen;
		Content = txtMessage = new TextBox { Width=250, Margin=new Thickness (10), Text="Ready" };
	}
}
