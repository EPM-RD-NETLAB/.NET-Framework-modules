<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	A();
}

async void A()
{
	await B(); 
}

async Task B()
{
	for (int i = 0; i < 1000; i++)
		await C().ConfigureAwait (false);
}

async Task C() { /*...*/ }