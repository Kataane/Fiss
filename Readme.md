
<div align="center">
<h1>Fiss</h1>
<div>

FlueIss - библиотека для взаимодействия с MOEX ISS.

## 📥 Установка
Установить можно [Fiss через NuGet](https://www.nuget.org/packages/Fiss):
```
Install-Package Fiss
```
Или через .NET Core command line interface:
```
dotnet add package Fiss
```
## 🔧 Использование
Чтобы начать использовать Fiss необходимо создать:
```csharp
var request = new IssRequest();
```
Далее необходимо определить путь запроса к ISS MOEX:
```csharp
var request = request.Engines().Engine(Engine.Stock).Markets();
```
Или
```csharp
var path = "engines/stock/markets";
var request = request.FullPath(path);
```
И даже так:
```csharp
var query = IssQueryFactory.Create(IssQuery.Eem, new[] { Engine.Stock});
var request = request.QueryConvert(query)
```
Добавляем параметры к запросу:
```csharp
request.AddQuery(new KeyValuePair<string, string>("lang", "en"));
```
После необходимо отправить запрос в MOEX ISS:
```csharp
await request.Fetch();
```
Ответ можно получить так:
```csharp
var respones = request.ToResponse();
```
или так:
```csharp
var respones = request.ToDynamic();
```
Вуаля! Теперь можно запрашивать любые, даже не задокументированые, данные из ISS MOEX.

## 📝 License 
[The MIT License (MIT)](https://mit-license.org/)

Made with love by Kataane 💜
