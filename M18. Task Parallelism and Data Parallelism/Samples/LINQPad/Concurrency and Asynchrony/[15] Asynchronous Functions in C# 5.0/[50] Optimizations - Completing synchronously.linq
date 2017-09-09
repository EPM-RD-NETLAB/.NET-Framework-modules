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

static Dictionary<string,string> _cache = new Dictionary<string,string>();

async Task<string> GetWebPageAsync (string uri)
{
	string html;
	if (_cache.TryGetValue (uri, out html)) return html;
	return _cache [uri] = await new WebClient().DownloadStringTaskAsync (uri);
}