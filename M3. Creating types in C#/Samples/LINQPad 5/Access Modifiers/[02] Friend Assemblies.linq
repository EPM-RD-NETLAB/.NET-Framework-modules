<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

// Unsigned friend:
//    [assembly: InternalsVisibleTo ("Friend")]

// Signed friend:
//    [assembly: InternalsVisibleTo ("StrongFriend, PublicKey=0024f000048c...")]

// To obtain an assembly's public key, hit F5 to run the following code:

using (var dialog = new OpenFileDialog())
{
	dialog.Title = "Locate assembly";
	dialog.Filter = "Assembly files|*.dll;*.exe";
	dialog.DefaultExt = ".dll";
	
	if (dialog.ShowDialog() != DialogResult.OK) return;
	if (!File.Exists (dialog.FileName)) return;
	
	var aName = Assembly.LoadFile (dialog.FileName).GetName();

	string key = string.Join ("", 
		aName.GetPublicKey().Select (b => b.ToString ("x2")).ToArray());
		
	string assemAttrib = "[assembly: InternalsVisibleTo (\"" 
		+ aName.Name
		+ ", PublicKey=" + key.Dump ("Full Key")
		+ "\")]";
		
	assemAttrib.Dump ("Assembly Attribute");
	
	Clipboard.SetText (assemAttrib);
}