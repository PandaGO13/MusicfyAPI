# MusicfyAPI

Este proyecto fue creado utilizando .NET CORE

## Cadena de Conexión (Development Mode)

Modificar la cadena de conexión en appsettings.Development.json en "defaultConnection".

```cs
"Data Source=.\\SQLEXPRESS; Initial Catalog=MusicfyAPI; Integrated Security=True"
```

En frontend_url se agrega el dominio del frontend para permitir su acceso.

## Creación BD

En la pestaña Package Manager Console, ingresar el siguiente comando.

```cs
Add-Migration InitialCreate
```
Luego,
```cs
Update-Database
```
