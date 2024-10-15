# BodegApp

## Descripción

**BodegApp** es una aplicación de gestión de inventario de vinos que permite a los usuarios administrar bodegas, ver el stock disponible y realizar operaciones como agregar, editar y eliminar vinos. El proyecto incluye una API REST que gestiona el backend, con autenticación JWT para el manejo seguro de usuarios.

## Características

- Gestión de inventario de vinos.
- Autenticación y autorización basada en tokens JWT.
- CRUD de usuarios y vinos.
- Arquitectura basada en varios proyectos para separación de responsabilidades.
- Uso de Entity Framework Core para acceso a base de datos.
- Documentación automática de la API con Swagger.

## Tecnologías Utilizadas

- **.NET 8.0** (Backend y API REST)
- **Entity Framework Core** (Acceso a datos)
- **SQLite** (Base de datos)
- **JWT** (Autenticación)
- **Swagger** (Documentación de la API)
- **C#** (Lenguaje principal)

## Estructura del Proyecto

```bash
├── Common/                # Clases comunes como modelos y enums
├── Data/                  # Manejo de la base de datos (Entities, Context, Repository)
├── Services/              # Lógica de negocio y servicios
├── BodegApp/              # Proyecto principal con controladores y configuración
├── appsettings.json       # Configuraciones de la aplicación
├── Program.cs             # Punto de entrada de la aplicación
└── README.md              # Este archivo
