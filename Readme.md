RU | [English](./docs/en_US.md)

<div align="center">
<h1>Fiss</h1>
<div>

Fiss - библиотека для строго-типизированного взаимодействия с MOEX ISS.

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

Чтобы начать использовать Fiss необходимо создать `IssRequest`:
```csharp
var request = new IssRequest();
```

Далее необходимо определить путь запроса к ISS MOEX:
```csharp
var request = request.Engines(Engine.Stock).Markets();
```

Или
```csharp
var path = "engines/stock/markets".Split("/");
request.AddPaths(path);
```

И даже так:
```csharp
request.AddPathFromFormattedQuery(IssQuery.Acss, "MOEX");
```

Добавляем параметры к запросу:
```csharp
request.AddQuery("lang", "en");
```

Ответ можно получить так:
```csharp
await request.ConvertToAsync<TResult>(IHttpContentSerializer, HttpClient, CancellationToken);
```

Если данных много, можно получить так:
```csharp
var cursor = await request.ToCursor<TResult>(IHttpContentSerializer, cursorTitle, index, total, PageSize, HttpClient, CancellationToken);
```

Или так
```csharp
var cursor = await request.ToCursor();
```

А потом
```csharp
await foreach (var page in cursor)
```

Вуаля! Теперь можно запрашивать любые, даже не задокументированые, данные из ISS MOEX.

## 📝 License 
[The MIT License (MIT)](https://mit-license.org/)

Made with love by Kataane 💜