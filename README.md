# TaskFlow (VB.NET) — Contenidos y cómo importarlo en Visual Studio

Este documento describe los archivos principales del proyecto TaskFlow-VB.NET y los pasos para abrirlo, restaurar dependencias y ejecutarlo en Visual Studio.

---

## Resumen rápido
TaskFlow es una aplicación escrita en Visual Basic .NET (Windows Forms). La solución y el proyecto principal están incluidos en la raíz del repositorio.

---

## Estructura y descripción de archivos principales

- `.gitattributes`  
  Configuraciones de Git para el repo.

- `.gitignore`  
  Archivos y carpetas ignoradas por Git (bin/, obj/, configuraciones locales, etc.).

- `TaskFlow.sln`  
  Archivo de solución de Visual Studio (abre la solución con Visual Studio).

- `TaskFlow.vbproj`  
  Archivo del proyecto VB.NET con referencias y configuración del compilador.

- `App.config`  
  Archivo de configuración de la aplicación. Contiene cadenas de conexión y ajustes que pueden requerir edición antes de ejecutar la app (por ejemplo, la configuración de la base de datos).

- `packages.config`  
  Lista de paquetes NuGet que utiliza el proyecto. Debes restaurarlos para compilar correctamente.

- Carpeta `My Project`  
  Contiene la configuración del proyecto (AssemblyInfo, configuración de aplicación, recursos, etc.).

- Formularios (Windows Forms)
  - `FrmLogin.vb`, `FrmLogin.Designer.vb`, `FrmLogin.resx`  
    Pantalla de inicio de sesión.
  - `FrmPrincipal.vb`, `FrmPrincipal.Designer.vb`, `FrmPrincipal.resx`  
    Formulario principal de la aplicación.
  - `FrmGestionUsuarios.vb`, `FrmGestionUsuarios.Designer.vb`, `FrmGestionUsuarios.resx`  
    Gestión de usuarios.
  - `FrmEdicionUsuario.vb`, `FrmEdicionUsuario.Designer.vb`, `FrmEdicionUsuario.resx`  
    Edición de un usuario.
  - `FrmCambioClave.vb`, `FrmCambioClave.Designer.vb`, `FrmCambioClave.resx`  
    Cambio de contraseña.
  - `FrmHistorial.vb`, `FrmHistorial.Designer.vb`, `FrmHistorial.resx`  
    Historial / auditoría.

  (Los archivos `.Designer.vb` contienen el código generado por el diseñador de forms y no deben editarse manualmente salvo que sepas lo que haces. Los `.resx` contienen recursos del formulario.)

- Código de lógica
  - `GestorDatos.vb`  
    Responsable del acceso a datos (posible capa de persistencia). Revisa `App.config` para la cadena de conexión usada aquí.
  - `LogicaUsuarios.vb`  
    Lógica de negocio relacionada con usuarios (autenticación, gestión).
  - `Usuario.vb`  
    Clase/estructura que representa un usuario dentro de la aplicación.

- `README.md`  
  Archivo README existente (vacío o pequeño). Puedes sustituirlo por uno más completo si lo deseas.

---

## Requisitos recomendados
- Visual Studio (2015/2017/2019/2022). Cualquier versión que soporte proyectos VB.NET Windows Forms y .NET Framework debería funcionar.
- .NET Framework compatible con el target del proyecto (revisar `TaskFlow.vbproj` si necesitas saber la versión exacta).
- Conexión a internet para restaurar paquetes NuGet (si no tienes los paquetes localmente).
- Si el proyecto usa una base de datos, necesitarás la misma (o configurar una nueva) y actualizar la cadena de conexión en `App.config`.

---

## Pasos para importar y ejecutar el proyecto en Visual Studio

1. Clona el repositorio (en tu máquina):
   - Desde línea de comandos:
     - git clone https://github.com/alexfupe/TaskFlow-VB.NET.git
     - cd TaskFlow-VB.NET
   - O descarga y descomprime el ZIP desde GitHub.

2. Abre la solución:
   - Dobleclic en `TaskFlow.sln` o abre Visual Studio → File → Open → Project/Solution → selecciona `TaskFlow.sln`.

3. Restaurar paquetes NuGet:
   - En el Explorador de Soluciones -> clic derecho en la solución -> "Restore NuGet Packages".  
   - Si usas la consola: `nuget restore TaskFlow.sln` o desde la terminal de VS: `dotnet restore` (nota: `dotnet restore` puede no aplicar a proyectos .NET Framework con packages.config; usa el restaurador de NuGet de Visual Studio o `nuget.exe`).

4. Revisar y ajustar la configuración:
   - Abre `App.config` y ajusta la cadena de conexión (connectionString) si la aplicación requiere acceso a una base de datos.  
   - Verifica en `My Project` → Application that the "Startup form" is correcto (si la aplicación no arranca en el formulario esperado, configúralo a `FrmPrincipal` o al que corresponda).

5. Build / Compilar:
   - En Visual Studio: Build → Build Solution (o Ctrl+Shift+B).
   - Si hay errores de referencias, revisa la ventana de errores y restaura/añade las referencias faltantes (por ejemplo, librerías NuGet).

6. Ejecutar:
   - Start Debugging (F5) o Start Without Debugging (Ctrl+F5).
   - La aplicación debería iniciar en la pantalla de login (`FrmLogin`) o en el formulario configurado como inicio.

---

## Solución de problemas comunes

- Error: paquetes NuGet faltantes / referencias no encontradas  
  - Asegúrate de restaurar `packages.config`. Si Visual Studio no restaura automáticamente, instala `nuget.exe` y ejecuta `nuget restore`.

- Error: conexión a base de datos  
  - Edita la cadena de conexión en `App.config` para apuntar a tu servidor/archivo de base de datos y credenciales correctas.

- Problemas con archivos `.Designer.vb` después de mover el proyecto  
  - Cierra Visual Studio, elimina las carpetas `bin/` y `obj/`, y luego vuelve a abrir la solución y recompila.

- Formulario de inicio incorrecto  
  - Project Properties → Application → Startup form → selecciona `FrmPrincipal` (o el que corresponda).

---

## Recomendaciones
- Mantén una copia de `App.config` con tus ajustes locales y NO la subas si contiene credenciales. Usa variables de entorno o un archivo separado para credenciales sensibles.
- Añade instrucciones adicionales en la raíz del repo (README.md) sobre requisitos de la base de datos (si aplica), esquemas SQL o cómo inicializar datos de ejemplo.
- Si planeas colaborar, documenta cómo ejecutar las pruebas (si las hubiese) y las convenciones de codificación.

---

Si quieres, puedo:
- Generar directamente este README.md y proponerte el contenido para un commit, o
- Inspeccionar `TaskFlow.vbproj` y `App.config` para darte instrucciones más precisas (por ejemplo, la versión exacta de .NET Framework y la cadena de conexión actual).
