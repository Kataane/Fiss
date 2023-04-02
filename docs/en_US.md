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

## 🛂 Passport MOEX
To authenticate on the Moscow Exchange, the following is required.

Install the Fiss.Client package:
```
Install-Package Fiss.Client
```

Or via the .NET Core command line interface:
```
dotnet add package Fiss.Client
```

Call the `AddMoexPassportClient` extension method for `IServiceCollection`:
```csharp
collection.AddMoexPassportClient("NameForMoexPassportClient", IConfigurationSection);
```

where `NameForMoexPassportClient` is a [unique](https://learn.microsoft.com/en-us/dotnet/core/extensions/httpclient-factory#named-clients) name for the client. `IConfigurationSection` is a [configuration](https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration) that stores the data for authentication on the MOEX.

Next, you need to get the named client:
```csharp
var client = IHttpClientFactory.CreateClient("NameForMoexPassportClient");
```

Then, using this client, you can request data that requires authorization.

The `MoexPassportClient` always keeps an up-to-date token for authorization, even if the token expires. MOEX will kindly issue a new token, and the client will become valid again.

Voila! Now you can request any data from MOEX, even undocumented or requiring authorization.

## 📝 License 
[The MIT License (MIT)](https://mit-license.org/)

Made with love by Kataane 💜