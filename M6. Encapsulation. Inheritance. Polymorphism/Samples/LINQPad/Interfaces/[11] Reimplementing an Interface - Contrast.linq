<Query Kind="Program" />

// Suppose that TextBox instead implemented Undo implicitly:

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
	public void Undo() { Console.WriteLine ("TextBox.Undo"); }
}

public class RichTextBox : TextBox, IUndoable
{
	public new void Undo() { Console.WriteLine ("RichTextBox.Undo"); }
}

static void Main()
{
	// This would give us another way to call Undo, which would “break” the system, as shown in Case 3:
	
	RichTextBox r = new RichTextBox();
	r.Undo();                 // RichTextBox.Undo      Case 1
	((IUndoable)r).Undo();    // RichTextBox.Undo      Case 2
	((TextBox)r).Undo();      // TextBox.Undo          Case 3
}