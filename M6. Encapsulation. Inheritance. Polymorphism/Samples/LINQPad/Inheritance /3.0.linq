<Query Kind="Program" />

public interface IUIControl 
{
	void Paint();
}
public interface IEditBox : IUIControl
{
	new void Paint();
}

public interface IDropList : IUIControl
{
	new void Paint();
}

public class ComboBox : IEditBox, IDropList
{
	void IEditBox.Paint()
	{
		Console.WriteLine("ComboBox.IEditBox.Paint()");
	}
	void IUIControl.Paint()
	{
		Console.WriteLine("ComboBox.IUIControl.Paint()");
	}
	public void Paint()
	{
		//((IUIControl)this).Paint(); 
		Console.WriteLine("ComboBox.Paint()");
	}
}
public class EntryPoint
{
	static void Main()
	{
		ComboBox cb = new ComboBox();
		cb.Paint();
		((IEditBox)cb).Paint();
		((IDropList)cb).Paint();
		((IUIControl)cb).Paint();
	}
}