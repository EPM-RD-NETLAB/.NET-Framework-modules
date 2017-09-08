<Query Kind="Program" />

abstract class ServiceClient
{
	public string ServiceUri{ get; set; }
	public abstract void SendData(object data);
	public abstract void Flush();
}

class HttpServiceClient : ServiceClient
{
	public override void SendData(object data)
	{
		var channel = OpenChannel(ServiceUri);
		channel.Send(data);
	}

	public override void Flush()
	{
		// Метод ничего не делает, но присутствует в классе
	}
}

class BufferingHttpServiceClient : ServiceClient
{
	public override void SendData(object data)
	{
		Buffer.Write(data);
	}

	public override void Flush()
	{
		var channel = OpenChannel(ServiceUri);
		channel.Send(Buffer.GetAll());
	}
}
//Решение этой проблемы заключается в проектировании грамотной иерархии 
//интерфейсов для уменьшения такой зависимости:

abstract class ServiceClient
{
	public string ServiceUri{ get; set; }
	public abstract void SendData(object data);
}

abstract class BufferingServiceClient : ServiceClient
{
	public abstract void Flush();
}

class HttpServiceClient : ServiceClient
{
	public override void SendData(object data){ ... }
}

class BufferingHttpServiceClient : BufferingServiceClient
{
	public override void SendData(object data){ ... }
	public override void Flush(){ ... }
}