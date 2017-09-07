<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	//...
	Button button = new Button();
	button.Text = "Click me";
	button.Click += new EventHandler(LogPlainEvent);
	button.KeyPress += new KeyPressEventHandler(LogKeyEvent);
	button.MouseClick += new MouseEventHandler(LogMouseEvent);
	Form form = new Form();
	form.AutoSize = true;
	form.Controls.Add(button);
	Application.Run(form);

	//vs

	Button button = new Button();
	button.Text = "Click me";
	button.Click += LogPlainEvent;
	button.KeyPress += LogPlainEvent;
	button.MouseClick += LogPlainEvent;
	Form form = new Form();
	form.AutoSize = true;
	form.Controls.Add(button);
	Application.Run(form);
}

//если вызов метода и применение его возвращаемого значения
//допустимо (в смысле статической типизации) во всех местах,
//где взамен можно было бы обратиться к экземпляру делегата 
//конкретного типа и использовать его конкретное значение,
//то такой метод может применяться для создания экземпляра  
//делегата этого типа

static void LogPlainEvent(object sender, EventArgs e)
{
	Console.WriteLine("LogPlain");
}
static void LogKeyEvent(object sender, KeyPressEventArgs e)
{
	Console.WriteLine("LogKey");
}
static void LogMouseEvent(object sender, MouseEventArgs e)
{
	Console.WriteLine("LogMouse");
}

void EventHandler(object sender, EventArgs e) { }
void KeyPressEventHandler(object sender, KeyPressEventArgs e) { }
void MouseEventHandler(object sender, MouseEventArgs e) { }

//ковариантность типов параметров

delegate Stream StreamFactory();

static MemoryStream GenerateSampleData()
{
	byte[] buffer = new byte[16];
	for (int i = 0; i < buffer.Length; i++)
	{
		buffer[i] = (byte)i;
	}
	return new MemoryStream(buffer);
}