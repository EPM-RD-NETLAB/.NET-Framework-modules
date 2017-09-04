<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;System.Dynamic.dll</Reference>
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Drawing</Namespace>
</Query>

// Type converters are designed to format and parse in design-time environments.

TypeConverter cc = TypeDescriptor.GetConverter (typeof (Color));

Color beige  = (Color) cc.ConvertFromString ("Beige");
Color purple = (Color) cc.ConvertFromString ("#800080");
Color window = (Color) cc.ConvertFromString ("Window");

beige.Dump();
purple.Dump();
window.Dump();