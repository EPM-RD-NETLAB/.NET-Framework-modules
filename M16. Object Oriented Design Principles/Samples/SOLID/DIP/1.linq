<Query Kind="Program" />

#region DIP
// Принцип инверсии (обращения) зависимости (Dependency Inversion Principle)

//Формулировка:
//Модули верхнего уровня не должны зависеть от модулей нижнего уровня. Оба должны зависеть от абстракции.
//Абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций.

//•	Жесткость - изменение одной части кода затрагивает слишком много других частей;
//•	Хрупкость - даже незначительное изменение в коде может привести к совершенно не
//ожиданным проблемам;
//•	Неподвижность - никакая из частей приложения не может быть легко выделена и
//повторно использована.

//Принцип обращения зависимости - это очень мощный инструмент, который в сочетании 
//с другими SOLID-принципами позволяет разрабатывать дизайн систем так же легко, 
//как если бы он собирался из конструктора LEGO.

#endregion
//Сейчас мы создадим и отрефакторим приложение. Будем двигаться по шагам и покажем 
//применение принципа инверсии зависимостей в действии.

#region Шаг 1. Сильная связанность
// Консольное приложением которое занимается рассылкой отчетов.
public class Program 
{
	public static void Main()
	{
		var reporter = new Reporter();
		reporter.SendReports();
	} 
}
//Главный объект в нашей бизнес-логике – Reporter
public class Reporter 
{
	 public void SendReports()
	 {
		var reportBuilder = new ReportBuilder();
		IList<Report> reports = reportBuilder.CreateReports();
  
		if (reports.Count == 0)
			throw new NoReportsException();
  
		var reportSender = new EmailReportSender();
		foreach (Report report in reports)
		{
			reportSender.Send(report);
		}
	}
}
//Устроен Reporter очень просто. Он просит ReportBuilder создать список отчетов, 
//а потом один за другим отсылает их с помощью объекта EmailReportSender.

//Есть ли в этом коде проблемы? В подавляющем большинстве случаев зависит от того, 
//кто и как этот код будет использовать, как часто он будет меняться и т.д.
//Но есть проблемы, которые очевидны уже сейчас.

//-----Тестируемость
//Как протестировать функцию SendReports? Давайте проверим поведение функции,
//когда ReportBuilder не создал ни одного отчета.
//В этом случае она должна создать исключение NoReportsException:
public class ReporterTests 
{
	 [Fact]
	 public void IfNotReportsThenThrowException()
	 {
		 var reporter = new Reporter();
		 reporter.SendReports();
		 // ???
	 }
}
//Как в этом случае задать поведение объектов, которые использует Reporter? 
//Мы же должны «сказать» ReportBuilder'у вернуть пустой список, и тогда функция 
//SendReports выбросит исключение. Но в текущей реализации Reporter'а сделать мы
//этого не можем. Получается, мы не можем задать такие входные данные, 
//при которых SendReports выкинет исключение. Значит в данной реализации 
//объект Reporter очень плохо поддается тестированию.

//-----Связанность
//Дело в том, что функция SendReports, кроме своей прямой обязанности, слишком много знает и умеет:
//-знает, что именно ReportBuilder будет создавать отчеты
//-знает, что все отчеты надо отсылать через email с помощью EmailReportSender
//-умеет создавать объект ReportBuilder
//-умеет создавать объект EmailReportSender

//Здесь нарушается принцип единственности ответственности.
//Проблема заключается в том, что в данный момент внутри функции SendReports 
//объект ReportBuilder создается оператором new. А если у него появятся 
//обязательные параметры в конструкторе? Нам придется менять код в классе 
//Reporter да и во всех других классах, которые использовали оператор new для ReportBuilder'а.

//К тому же, первые пункты нарушают принцип открытости/закрытости. 
//Дело в том, что если мы захотим с помощью нашей утилиты отсылать сообщения через SMS,
//то придется изменять код класса Reporter. Вместо EmailReportSender мы должны будем 
//написать SmsReportSender. Еще сложнее ситуация, когда одна часть пользователей класса 
//Reporter захочет отправлять сообщения через emal, а вторая через SMS.

//Обратите внимание, что наш объект Reporter зависит не от абстракций, а 
//от конкретных объектов ReportBuilder и EmailReportSender. Можно сказать, 
//что он "сцеплен" с этими классами. Это и объясняет его хрупкость при изменениях в системе. 
//Может оказаться, что Reporter жестко зависит от двух классов, эти два класса зависят еще 
//от 4х других. Получится, что вся система – это клубок из стальных ниток, который 
//нельзя ни изменить, ни протестировать. Этот пример наглядно показывает нарушение
//принципа инверсии зависимостей.

#endregion

#region Шаг 2. Применяем принцип инверсии зависимостей
//Для начала вынесем интерфейсы IReportSender из EmailReportSender и IReportBuilder из ReportBuilder.
public interface IReportBuilder 
{
	IList<Report> CreateReports();
}
  
public interface IReportSender 
{
	void Send(Report report);
}
//Теперь вместо того, чтобы создавать объекты в функции SendReports, 
//мы передами их объекту Reporter в конструктор:

public class Reporter : IReporter 
{
	 private readonly IReportBuilder reportBuilder;
	 private readonly IReportSender reportSender;
  
	 public Reporter(IReportBuilder reportBuilder, IReportSender reportSender)
	 {
		 this.reportBuilder = reportBuilder;
		 this.reportSender = reportSender;
	 }
  
	 public void SendReports()
	 {
		IList<Report> reports = reportBuilder.CreateReports();
  
		if (reports.Count == 0)
			throw new NoReportsException();
  
		foreach (Report report in reports)
		{
			reportSender.Send(report);
		}
	}
}
//Во время создания объекта Reporter в самом начале программы мы будем
//задавать конкретные IReportBuilder и IReportSender и передавать их в конструктор:
public static void Main()
{
	 var builder = new ReportBuilder();
	 var sender = new SmsReportSender();
	 var reporter = new Reporter(builder, sender);
  
	 reporter.SendReports();
}
//Тестируемость+
//Теперь у нас есть возможность передавать в конструктор Reporter'а 
//объекты, которые реализуют нужные интерфейсы. Давайте подставим 
//mock-объекты и зададим нужное нам поведение:
//Связанность+
#endregion