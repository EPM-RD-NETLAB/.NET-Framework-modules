<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Security.AccessControl</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

MessageBox.Show (
	"Named arguments work with or without optional parameters!",
	"Take note!",
	MessageBoxButtons.OK,
	MessageBoxIcon.Information);

// Можно и так
	
MessageBox.Show (
	text: "Named arguments work with or without optional parameters!",
	caption : "Take note!",
	buttons: MessageBoxButtons.OK,
	icon: MessageBoxIcon.Information);
	
// Но есть нюанс - изменение имен параметров!