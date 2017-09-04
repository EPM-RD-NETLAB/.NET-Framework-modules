<Query Kind="Program" />

// We can extend interfaces - just like extending classes:

public interface IUndoable             { void Undo(); }
public interface IRedoable : IUndoable { void Redo(); }

static void Main()
{
	IRedoable r = null;
	IUndoable u = r;
}
