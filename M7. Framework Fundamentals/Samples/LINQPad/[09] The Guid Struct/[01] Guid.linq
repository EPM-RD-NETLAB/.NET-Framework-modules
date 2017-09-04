<Query Kind="Statements" />

Guid g = Guid.NewGuid ();
g.ToString().Dump ("Guid.NewGuid.ToString()");

Guid g1 = new Guid ("{0d57629c-7d6e-4847-97cb-9e2fc25083fe}");
Guid g2 = new Guid ("0d57629c7d6e484797cb9e2fc25083fe");
Console.WriteLine (g1 == g2);  // True

byte[] bytes = g.ToByteArray();
Guid g3 = new Guid (bytes);
g3.Dump();

Guid.Empty.Dump ("Guid.Empty");
default(Guid).Dump ("default(Guid)");
Guid.Empty.ToByteArray().Dump ("Guid.Empty - bytes");
