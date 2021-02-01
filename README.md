# dotnet-core-ibge-client

### Exemplo:

```
IIbgeAPI client = IbgeClientFactory.IbgeClient;

IList<Distrito> distritos = await client.GetDistritosAsync();
```

### Pacote Nuget (.NET CLI):

```
dotnet add package IbgeClient --version 1.0.2
```
