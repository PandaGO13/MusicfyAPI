# MusicfyAPI

Este proyecto fue creado utilizando .NET CORE

## AppSettings (Development Mode)

Modificar la cadena de conexión en appsettings.Development.json en "defaultConnection". Ejm:

```cs
"Data Source=.\\SQLEXPRESS; Initial Catalog=MusicfyAPI; Integrated Security=True"
```

En frontend_url se agrega el dominio del frontend para permitir su acceso. Ejm:

```cs
"http://localhost:3000"
```

## Creación BD

En la pestaña Package Manager Console, ingresar el siguiente comando.

```cs
Add-Migration InitialCreate
```
Luego,
```cs
Update-Database
```
