<Query Kind="Program" />

class A 
{ 
   public virtual void m1() {   } 
} 
class B : A 
{ 
   public override void m1() {   } 
} 
class C : B 
{ 
   public override void m1() 
   {
		/* програмный код */
	}
}

//Из класса C невозможно обратиться к методу m1() 
//класса A для одного и того же объекта
//Из класса C можно получить доступ к методу m1()
//класса B используя вызов base.m1()