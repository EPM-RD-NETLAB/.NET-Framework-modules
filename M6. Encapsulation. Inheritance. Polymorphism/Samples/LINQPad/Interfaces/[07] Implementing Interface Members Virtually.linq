<Query Kind="Program" />

// An implicitly implemented interface member is, by default, sealed. It must be marked
// virtual or abstract in the base class in order to be overridden:

public interface IUndoable { void Undo(); }

public class TextBox : IUndoable
{
	public virtual void Undo()
	{
		Console.WriteLine ("TextBox.Undo");
	}
}

public class RichTextBox : TextBox
{
	public override void Undo()
	{
		Console.WriteLine ("RichTextBox.Undo");
	}
}

static void Main()
{
	// Calling the interface member through either the base class or the interface
	// calls the subclass’s implementation:
	RichTextBox r = new RichTextBox();
	r.Undo();                          // RichTextBox.Undo
	((IUndoable)r).Undo();             // RichTextBox.Undo
	((TextBox)r).Undo();               // RichTextBox.Undo
}