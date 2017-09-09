<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

Parallel.Invoke (
	() => new WebClient().DownloadFile ("http://www.linqpad.net", "lp.html"),
	() => new WebClient().DownloadFile ("http://www.jaoo.dk", "jaoo.html"));
