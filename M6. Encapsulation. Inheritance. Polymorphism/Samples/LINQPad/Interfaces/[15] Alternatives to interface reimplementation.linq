<Query Kind="Program" />

// Even with explicit member implementation, interface reimplementation is problematic for a couple of reasons.
// The following pattern is a good alternative if you need explicit interface implementation:

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
	void IUndoable.Undo()         { Undo(); }   // Calls method below
	protected virtual void Undo() { Console.WriteLine ("TextBox.Undo"); }
}

public class RichTextBox : TextBox
{
	protected override void Undo() { Console.WriteLine ("RichTextBox.Undo"); }
}

static void Main()
{
	IUndoable r = new RichTextBox();
	r.Undo();		// RichTextBox.Undo
}
