<div align="center">
<h1>Fiss</h1>
<div>

Fiss is a library for strongly-typed interaction with MOEX ISS.

## 📥 Installation
You can install [Fiss via NuGet](https://www.nuget.org/packages/Fiss):
```
Install-Package Fiss
```

Or via the .NET Core command line interface:
```
dotnet add package Fiss
```

## 🔧 Usage

To start using Fiss, you need to create an `IssRequest`:
```csharp
var request = new IssRequest();
```

Next, you need to define the path to the request to MOEX ISS:
```csharp
var request = request.Engines(Engine.Stock).Markets();
```

Or
```csharp
var path = "engines/stock/markets".Split("/");
request.AddPaths(path);
```

And even like this:
```csharp
request.AddPathFromFormattedQuery(IssQuery.Acss, "MOEX");
```

Add query to the request:
```csharp
request.AddQuery("lang", "en");
```

You can get the response like this:
```csharp
await request.ConvertToAsync<TResult>(IHttpContentSerializer, HttpClient, CancellationToken);
```

If there is a lot of data, you can get it like this:
```csharp
var cursor = await request.ToCursor<TResult>(IHttpContentSerializer, cursorTitle, index, total, PageSize, HttpClient, CancellationToken);
```

Or like this:
```csharp
var cursor = await request.ToCursor();
```

And then:
```csharp
await foreach (var page in cursor)
```

Voila! Now you can request any data from MOEX ISS, even undocumented ones.

## 📝 License 
[The MIT License (MIT)](https://mit-license.org/)

Made with love by Kataane 💜