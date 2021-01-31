# dotnet-core-ibge-client

### Exemplo:

```
IIbgeAPI client = IbgeClientFactory.IbgeClient;

IList<Distrito> distritos = await client.GetDistritos();
```