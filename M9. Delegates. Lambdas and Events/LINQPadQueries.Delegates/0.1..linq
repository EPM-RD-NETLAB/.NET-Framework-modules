<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

// Два выражения создания экземпляров делегатов d1 и d2 эквивалентны. 
// Здесь InstanceMethod является экземплярным методом, который объявлен 
//в классе, в котором также объявлены нижеприведённые выражения (базовый класс).
//Соответственно, ссылка на экземпляр объекта — this, и именно поэтому эти 
//выражения эквивалентны. 

FirstDelegate d1 = new FirstDelegate(InstanceMethod);
FirstDelegate d2 = new FirstDelegate(this.InstanceMethod);

// Здесь (d3) мы создаём экземпляр делегата, ссылающийся на тот же метод,
//что и в предыдущих двух выражениях, но на этот раз с другим экземпляром класса.

FirstDelegate d3 = new FirstDelegate(anotherInstance.InstanceMethod);

// В этом (d4) экземпляре делегата используется уже другой метод, тоже экземплярный,
//который объявлен в другом классе; мы указываем экземпляр этого класса и сам метод. 
FirstDelegate d4 = new FirstDelegate(instanceOfOtherClass.OtherInstanceMethod);

// А вот этот (d5) экземпляр делегата использует статический метод, который 
//расположен в том же классе, где и это выражение (базовом классе).
FirstDelegate d5 = new FirstDelegate(StaticMethod);

// Здесь (d6) экземпляр делегата использует другой статический метод,
//объявленный на этот раз в стороннем классе. 
FirstDelegate d6 = new FirstDelegate(OtherClass.OtherStaticMethod);