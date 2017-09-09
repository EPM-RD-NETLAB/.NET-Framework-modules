<Query Kind="Program" />

#region Принцип единственного выбора
//Отвечает ли реализация фабрики принципу «открыт/закрыт»?
// Бертран Мейер по этому поводу:
//«Необходимо допускать возможность того, что список вариантов,
//заданных и известных на некотором этапе разработки программы,
//может в последующем быть изменен путем добавления или удаления 
//вариантов.Чтобы обеспечить реализацию такого подхода к процессу 
//разработки программного обеспечения, нужно найти способ защитить
//структуру программы от воздействия подобных изменений. Отсюда
//следует принцип Единственного Выбора».
//===================================================================
//Принцип единственного выбора: всякий раз, когда система программного
//обеспечения должна поддерживать множество альтернатив, их 
//полный список должен быть известен только одному модулю системы.
//====================================================================
#endregion

abstract class IImporter
{
    public abstract void ImportData();
}

class JsonImporter : IImporter
{
	public override void ImportData() {//TODO}
}

class XlsImporter : IImporter
{
	public override void ImportData() {//TPDO }
}

static class ImporterFactory
{
    public static IImporter Create(string fileName)
    {
        //...
 
        var extension = Path.GetExtension(fileName);
        switch (extension)
        {
            case "json":
                return new JsonImporter();
            case "xls":
            case "xlsx":
                return new XlsImporter();
            default:
                throw new InvalidOperationException(
                  "Extension is not supported");
        }
    }
}