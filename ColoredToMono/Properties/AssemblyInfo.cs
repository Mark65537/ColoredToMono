﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Общие сведения об этой сборке предоставляются следующим набором
// набора атрибутов. Измените значения этих атрибутов для изменения сведений,
// связанных со сборкой.
[assembly: AssemblyTitle("ColoredToMono")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ColoredToMono")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Установка значения False для параметра ComVisible делает типы в этой сборке невидимыми
// для компонентов COM. Если необходимо обратиться к типу в этой сборке через
// COM, следует установить атрибут ComVisible в TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("1f14977b-5c90-47b5-b26b-5a988f7012ca")]

// Сведения о версии сборки состоят из указанных ниже четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии
//      Номер сборки
//      Редакция
//
// Можно задать все значения или принять номера сборки и редакции по умолчанию 
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
//Если выдает ошибку, то нужно в файле проекта .csproj заменить значение параметра
//< Deterministic > ...</ Deterministic > с true на false.
[assembly: AssemblyVersion("2.2.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]

/*РУС
 * Как Ставиться Версия
 * -Если меняется интерфейс приложения то добавляется 1я цыфра
 * -Если меняется алгоритм приложения то добавляется 2я цыфра
 * -Остальные изменяются при сборке
 */