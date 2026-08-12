# Calculadora-CSharp

Aplicación de consola desarrollada en C# y .NET 8 como parte de mi portafolio de desarrollo de software.

## Objetivo

Desarrollar una aplicación de consola capaz de realizar operaciones matemáticas básicas de forma sencilla, segura y con validación de entradas.

Este proyecto forma parte de mi proceso de aprendizaje en análisis, diseño y desarrollo de software, utilizando C# como lenguaje principal.

## Funcionalidades

- Suma de dos números.
- Resta de dos números.
- Multiplicación de dos números.
- División de dos números.
- Validación de entradas numéricas.
- Prevención de división entre cero.
- Menú interactivo.
- Opción para salir de la aplicación.

## Requerimientos funcionales

| ID | Requerimiento |
|---|---|
| RF01 | El usuario podrá realizar una suma. |
| RF02 | El usuario podrá realizar una resta. |
| RF03 | El usuario podrá realizar una multiplicación. |
| RF04 | El usuario podrá realizar una división. |
| RF05 | El programa deberá impedir la división entre cero. |
| RF06 | El usuario podrá salir del programa. |

## Requerimientos no funcionales

- Utilizar C#.
- Utilizar .NET 8.
- Aplicación de consola.
- Código legible y mantenible.
- Validación de entradas del usuario.
- Control de versiones mediante Git.
- Código publicado en GitHub.
- Documentación del proyecto mediante README.

## Herramientas de desarrollo

- Visual Studio Code
- Continue
- Ollama
- Qwen 2.5 Coder 7B

## Tecnologías utilizadas

- C#
- .NET 8
- Git
- GitHub

## Herramientas de desarrollo

- Visual Studio Code
- Continue
- Ollama
- Qwen 2.5 Coder 7B

## Estructura del proyecto

```text
Calculadora-CSharp/
├── .gitignore
├── Calculadora-CSharp.csproj
├── Program.cs
└── README.md
```

> Las carpetas `bin/` y `obj/` son generadas por .NET y están excluidas del repositorio mediante `.gitignore`.

## Cómo ejecutar el proyecto

### Requisitos

- .NET 8 SDK
- Git

### Clonar el repositorio

```bash
git clone git@github.com:RED-BMX/Calculadora-CSharp.git
```

### Entrar al proyecto

```bash
cd Calculadora-CSharp
```

### Compilar

```bash
dotnet build
```

### Ejecutar

```bash
dotnet run
```