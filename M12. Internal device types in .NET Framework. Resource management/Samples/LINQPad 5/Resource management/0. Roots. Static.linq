<Query Kind="Program" />

class Program
{
	static event EventHandler ButtonClick;

	static void Main(string[] args)
	{
		while (true)
		{
			Button button = new Button();
			ButtonClick += button.OnClick;
		}
	}
}

class Button
{
	public void OnClick(object sender, EventArgs e)
	{
		// TODO
	}
}