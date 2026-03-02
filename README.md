# TaskFlow (VB.NET) — Resumen rápido y cómo abrirlo 🚀

Breve guía para importar y ejecutar el proyecto en Visual Studio, y por qué debes añadir el paquete NuGet de MongoDB. 😊

## Archivos principales
- `TaskFlow.sln` — Solución (abrir con Visual Studio).  
- `TaskFlow.vbproj` — Proyecto VB.NET.  
- `App.config` — Configuración (cadena de conexión).  
- `My Project/` — Configuración del proyecto y recursos.  
- Formularios: `FrmLogin*`, `FrmPrincipal*`, `FrmGestionUsuarios*`, `FrmEdicionUsuario*`, `FrmCambioClave*`, `FrmHistorial*`.  
- Lógica: `GestorDatos.vb`, `LogicaUsuarios.vb`, `Usuario.vb`.  

## Pasos rápidos para abrir y ejecutar
1. Clona o descarga el repositorio.  
   git clone https://github.com/alexfupe/TaskFlow-VB.NET.git  
2. Abre `TaskFlow.sln` con Visual Studio. 🖥️  
3. Restaura paquetes NuGet: clic derecho en la solución → Restore NuGet Packages. 🔁  
4. Si falta, instala el driver de MongoDB:  
   - Visual Studio → Tools → NuGet Package Manager → Manage NuGet Packages for Solution → buscar `MongoDB.Driver` → instalar ✅  
   - O en Package Manager Console: `Install-Package MongoDB.Driver`  
5. Edita `App.config` para poner tu cadena de conexión a la base de datos (si aplica). 🔧  
6. Build → Build Solution y luego F5 para ejecutar.

## ¿Por qué agregar el NuGet `MongoDB.Driver`? 📝
El paquete `MongoDB.Driver` contiene el driver oficial de MongoDB para .NET. Si el proyecto guarda o lee datos desde MongoDB, el código (por ejemplo en `GestorDatos.vb`) usa las clases del driver para conectarse, realizar consultas y operaciones. Sin este paquete, las referencias a esas clases no existirán y el proyecto no compilará. 🔌

Resumen:
- Provee la API para conectar y operar con MongoDB.  
- Maneja serialización/deserialización de documentos BSON.  
- Soporta operaciones asíncronas, filtros y mapeos necesarios por la app.

## Solución de problemas rápidos 🛠️
- Error de referencia a tipos MongoDB → instala `MongoDB.Driver`.  
- Problemas de conexión → revisa y actualiza la cadena en `App.config`. 🔒  
- Si ves errores tras mover el proyecto: borra `bin/` y `obj/`, luego recompila.
