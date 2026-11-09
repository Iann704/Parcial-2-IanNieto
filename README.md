# Parcial Práctico: Laboratorio de MVP

**Universidad Tecnológica de Panamá**
Facultad de Ingeniería en Sistemas Computacionales, Campus Víctor Levis Sasso
Herramientas de la Programación Aplicada III (.NET), Grupo 1IL133, II Semestre 2026

- **Autor:** Ian Nieto
- **Instructora:** Ing. Irina Fong
- **Fecha:** [fecha de entrega]

## Descripción

Aplicación de escritorio en Windows Forms con inicio de sesión seguro. Los usuarios se registran, su contraseña se guarda como **hash con salt** (nunca en texto plano) en SQL Server, y después pueden iniciar sesión y entrar a una pantalla principal con menú lateral colapsable, reloj en tiempo real y el nombre del usuario en sesión.

El proyecto aplica el patrón **MVP** (Modelo-Vista-Presentador) sobre una arquitectura en capas.

## Funcionalidades

- Registro de usuarios con validaciones (campos obligatorios, correo, longitud mínima de contraseña, confirmación y usuario duplicado).
- Inicio de sesión con verificación del hash.
- Pantalla principal con:
  - Menú lateral izquierdo con iconos, que se achica y se expande con animación.
  - Reloj con la hora actual.
  - Usuario que inició sesión, en la parte inferior del menú.
- Cambio de contraseña del usuario en sesión (exige la contraseña actual).
- Conexión a la base de datos con un usuario de **privilegios mínimos**.

## Tecnologías y versiones

| Tecnología | Versión |
|---|---|
| Lenguaje | C# [versión] |
| Plataforma | .NET [versión, ej. 8.0] |
| Interfaz | Windows Forms |
| Base de datos | SQL Server [versión] |
| IDE | Visual Studio [versión] |
| Paquete NuGet | Microsoft.Data.SqlClient [versión] |

## Arquitectura

```
Presentacion  →  Negocio  →  Datos  →  Entidades
```

| Proyecto | Responsabilidad |
|---|---|
| `Entidades` | Clases que representan los datos (`Usuario`). |
| `Datos` | Conexión a SQL Server y repositorio que ejecuta los Stored Procedures. |
| `Negocio` | Reglas de negocio, validaciones y servicios de hash. |
| `Presentacion` | Vistas (formularios), interfaces de las vistas y presentadores. |

### Contratos de hash (capa de Negocio)

- `IHashService`: su única responsabilidad es generar el hash.
- `IVerificarHashService`: su única responsabilidad es verificar si una contraseña en texto plano coincide con el hash almacenado.
- `Pbkdf2PasswordService` implementa ambas con PBKDF2 (SHA-256, 100 000 iteraciones y salt aleatorio de 16 bytes). Se guarda como `salt.hash` en Base64.

### Patrón MVP

La **Vista** solo muestra controles y avisa al **Presentador** mediante eventos. El Presentador llama a la capa de Negocio y devuelve el resultado a la Vista a través de una interfaz (`ILoginView`, `IRegistroView`, `IPrincipalView`, `ICambiarContrasenaView`). La Vista no conoce el hash ni la base de datos.

## Base de datos
 
 Crea:
- La base de datos `Parcial#2` y la tabla `usuario`.
- Los procedimientos `sp_RegistroUsuario`, `sp_BusquedaUsuario` y `sp_CambiarContrasena`.
- El login `aplicacion` y el usuario `aplicacion_parcial2`, que **solo** tiene permiso `EXECUTE` sobre esos procedimientos. No puede leer ni modificar las tablas directamente.

## Instalación

### Requisitos

- Windows 10 u 11
- Visual Studio con la carga de trabajo de escritorio de .NET
- SQL Server con **autenticación mixta** activada

### Pasos

1. Clona el repositorio:
   ```bash
   git clone [URL del repositorio]
   ```
2. Abre `Parcial#2-IanNieto.sln` en Visual Studio.
3. En SQL Server Management Studio, ejecuta `BaseDeDatos/script.sql`. Cambia la contraseña de ejemplo del login por una tuya.
4. Crea la variable de entorno con la cadena de conexión (en PowerShell):
   ```powershell
   setx PARCIAL_CONEXION "Server=localhost;Database=Parcial#2;User Id=aplicacion;Password=TU_CLAVE;TrustServerCertificate=True;"
   ```
5. **Cierra y vuelve a abrir Visual Studio**, porque solo lee las variables al iniciar.
6. Verifica que el proyecto de inicio sea `Presentacion` y pulsa **F5**.

> La contraseña no está escrita en el código fuente. Se lee de la variable de entorno `PARCIAL_CONEXION`.

## Controles utilizados

- `Form`, `Panel`, `Label`, `TextBox` (con `UseSystemPasswordChar`), `Button`
- `Timer` (reloj y animación del menú)
- `ToolTip` (nombres de los botones cuando el menú está colapsado)
- Iconos de la fuente *Segoe MDL2 Assets*

## Autor

**Ian Nieto**, Grupo 1IL133, II Semestre 2026
Fecha: [fecha]
