<Query Kind="Program" />

void Main()
{	
	new Thread (() => UserCache.GetUser (1).Dump()).Start();
	new Thread (() => UserCache.GetUser (1).Dump()).Start();
	new Thread (() => UserCache.GetUser (1).Dump()).Start();
}

static class UserCache
{
	static Dictionary <int, User> _users = new Dictionary <int, User>();
	
	internal static User GetUser (int id)
	{
		User u = null;
		
		lock (_users)
			if (_users.TryGetValue (id, out u))
				return u;
		
		u = RetrieveUser (id);           // Method to retrieve from database;
		lock (_users) _users [id] = u;
		return u;
	}

	static User RetrieveUser (int id)
	{
		return new User { ID = id };
	}
}

class User { public int ID; }