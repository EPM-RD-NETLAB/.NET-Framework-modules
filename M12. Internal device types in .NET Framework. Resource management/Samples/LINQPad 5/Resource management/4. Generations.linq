<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Debug.WriteLine("***** Fun with System.GC *****");

	Debug.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
	Debug.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

	Car refToMyCar = new Car("Zippy", 100);
	Debug.WriteLine(refToMyCar.ToString());

	Debug.WriteLine("\nGeneration of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
	GC.Collect(0);
	GC.WaitForPendingFinalizers();
	Debug.WriteLine("\nGeneration of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
	// для целей тестирования. 
	object[] tonsOfObjects = new object[50000];
	for (int i = 0; i < 50000; i++)
		tonsOfObjects[i] = new object();
	Debug.WriteLine("\nGeneration of tonsOfObjects is: {0}", GC.GetGeneration(tonsOfObjects));
	//перечисление GCCollectionMode(Default,Forced,Optimized)
	GC.Collect(0, GCCollectionMode.Forced);
	GC.WaitForPendingFinalizers();
	//GC.Collect(0, GCCollectionMode.Forced);

	Debug.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));
	GC.AddMemoryPressure(Int32.MaxValue);
	Debug.WriteLine("tonsOfObjects[9000] is no longer alive.");

	// Вывод информации о том, сколько раз в отношении 
	// объектов каждого поколения выполнялась сборка мусора. 
	Debug.WriteLine("\nGen 0 has been swept {0} times", GC.CollectionCount(0));
	Debug.WriteLine("Gen 1 has been swept {0} times", GC.CollectionCount(1));
	Debug.WriteLine("Gen 2 has been swept {0} times", GC.CollectionCount(2));

}

public class Car
{
	public int CurrentSpeed { get; set; }
	public string PetName { get; set; }

	public Car() { }
	public Car(string name, int speed)
	{
		PetName = name;
		CurrentSpeed = speed;
	}
	public override string ToString()
	{
		return string.Format("{0} is going {1} MPH", PetName, CurrentSpeed);
	}
}