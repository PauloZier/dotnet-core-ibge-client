# dotnet-core-ibge-client

### Exemplo:

```csharp
IIbgeAPI client = IbgeClientFactory.IbgeClient;

IList<Distrito> distritos = await client.GetDistritosAsync();
```

### Pacote Nuget (.NET CLI):

```
dotnet add package IbgeClient
```
