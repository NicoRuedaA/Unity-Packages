# Unity Packages & Utilities

Una colección completa de herramientas, patrones de diseño y utilidades para potenciar el desarrollo en Unity, optimizando desde la arquitectura del código hasta el flujo de trabajo en el editor.

---

## 💎 Unity Singleton System

Implementaciones robustas y thread-safe del patrón Singleton, diseñadas para una gestión de instancias global limpia y eficiente.

### Características
- **ISingleton**: Interfaz base para garantizar una estructura consistente.
- **MonoSingleton<T>**: Para componentes de escena que se destruyen al cambiar de nivel.
- **PersistentMonoSingleton<T>**: Para managers globales que persisten entre escenas (`DontDestroyOnLoad`).
- **Singleton<T>**: Implementación para clases de C# puro (thread-safe).
- **Control de Estado**: Seguimiento del estado de inicialización (`None`, `Initializing`, `Initialized`).

### Ejemplo de Uso (Persistent)
```csharp
public class GameManager : PersistentMonoSingleton<GameManager>
{
    protected override void OnInitialized()
    {
        Debug.Log("GameManager global inicializado.");
    }
}
```

---

## 🛠️ Editor Tools (`/Tools`)

Aumenta tu productividad con utilidades que automatizan las tareas más tediosas del setup inicial.

- **Setup de Carpetas**: Menú `Tools/Setup/Create Default Folders` para generar la estructura `_Project`, `Scripts`, `Art`, `Scenes`.
- **Manifest Sync**: Reemplaza el `manifest.json` de tu proyecto directamente desde un GitHub Gist.
- **Acceso Rápido a Paquetes**: Instalación instantánea de Input System, Post Processing y Cinemachine desde el menú superior.

---

## 📄 Text File Reader (`/Text file reader`)

Procesa archivos de texto de forma visual y sencilla.

- **TextReader Component**: Asigna un `TextAsset` y separa automáticamente las líneas en un array de strings.
- **Previsualización en Editor**: Utiliza `OnValidate` para ver los resultados instantáneamente en el Inspector sin necesidad de darle a Play.

---

## 🚀 Instalación

Añade la siguiente línea al archivo `manifest.json` de tu proyecto Unity:

```json
"com.unitycommunity.unitysingleton": "https://github.com/tu-usuario/unity-packages.git"
```

## Estructura del Repositorio
- `UnitySingleton/`: Lógica central de Singletons y samples.
- `Tools/`: Scripts de extensión del editor.
- `Text file reader/`: Componentes para lectura de datos.

## Licencia
Este proyecto está bajo la licencia MIT.
