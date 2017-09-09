<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	int totalSize = await GetTotalSize ("http://www.linqpad.net http://www.albahari.com http://stackoverflow.com".Split());
	totalSize.Dump();
}

async Task<int> GetTotalSize (string[] uris)
{
	IEnumerable<Task<int>> downloadTasks = uris.Select (async uri =>
		(await new WebClient().DownloadDataTaskAsync (uri)).Length);
		
	int[] contentLengths = await Task.WhenAll (downloadTasks);
	return contentLengths.Sum();
}
