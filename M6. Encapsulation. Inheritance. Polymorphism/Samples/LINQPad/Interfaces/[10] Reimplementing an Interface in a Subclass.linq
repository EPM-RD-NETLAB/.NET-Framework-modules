<Query Kind="Program" />

// A subclass can reimplement any interface member already implemented by a base class.
// Reimplementation hijacks a member implementation (when called through the interface):

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
	void IUndoable.Undo() { Console.WriteLine ("TextBox.Undo"); }
}

public class RichTextBox : TextBox, IUndoable
{
	public new void Undo() { Console.WriteLine ("RichTextBox.Undo"); }
}

static void Main()
{
	// Calling the reimplemented member through the interface calls the subclass’s implementation:
	RichTextBox r = new RichTextBox();
	r.Undo();                 // RichTextBox.Undo      Case 1
	((IUndoable)r).Undo();    // RichTextBox.Undo      Case 2
}