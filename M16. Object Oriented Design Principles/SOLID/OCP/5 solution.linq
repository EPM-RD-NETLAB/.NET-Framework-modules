<Query Kind="Program" />

//Конкретизируя классы методом is или typeof следует сразу понять,
//что наш код начал «попахивать». Чтобы решить данную проблему,
//необходимо логику сохранения конкретных классов из иерархии 
//AbstractEntity вынести в конкретные классы Repository. 
//Для этого мы должны выделить интерфейс IRepository и создать
//хранилища AccountRepository и RoleRepository:

public abstract class AbstractEntity{ }
 
public class AccountEntity : AbstractEntity{ }
 
public class RoleEntity : AbstractEntity{ }
 
public interface IRepository<T> where T : AbstractEntity
{
    void Save(T entity);
}
 
public class AccountRepository : IRepository<AccountEntity>
{
    public void Save(AccountEntity entity)
    {
        // специфические действия для AccountEntity
    }
}
 
public class RoleRepository : IRepository<RoleEntity>
{
    public void Save(RoleEntity abstractEntity)
    {
        // специфические действия для RoleEntity
    }
}