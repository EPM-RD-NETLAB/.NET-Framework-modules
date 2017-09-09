<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async void Main()
{
	string html = await GetWebPageAsync ("http://www.linqpad.net");
	html.Length.Dump ("Characters downloaded");
	
	// Let's try again. It should be instant this time:
	html = await GetWebPageAsync ("http://www.linqpad.net");
	html.Length.Dump ("Characters downloaded");
}

static Dictionary<string,Task<string>> _cache = 
   new Dictionary<string,Task<string>>();

Task<string> GetWebPageAsync (string uri)
{
	Task<string> downloadTask;
	if (_cache.TryGetValue (uri, out downloadTask)) return downloadTask;
	return _cache [uri] = new WebClient().DownloadStringTaskAsync (uri);
}