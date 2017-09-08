<Query Kind="Statements" />

//Простым и действенным выходом является использование шаблона Repository. 
//Хранилищу AccountRepository мы оставляем работу с базой данных и 
//получаем «чистый» доменный объект.

// создание пользователя
var account = new Account();
account.Name = "Name";
accountRepository.Save(account);
 
// загрузка пользователя по Id
var account = accountRepository.GetById(1);
 
// загрузка со связной коллекцией
// пример из LLBLGen Pro
var account = accountRepository.GetById(1, new IPath[]{new Path<Account>(Account.PrefetchPathRoles)});