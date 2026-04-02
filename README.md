# Unity Singleton & Tools

Una colección de implementaciones robustas y eficientes del patrón Singleton para Unity, diseñadas para facilitar la gestión de instancias globales tanto en clases de C# puro como en `MonoBehaviour`.

## Características

- **ISingleton**: Interfaz base para garantizar una estructura consistente de inicialización y limpieza.
- **MonoSingleton<T>**: Implementación para `MonoBehaviour` que se destruye al cambiar de escena. Crea automáticamente el GameObject si no existe en la escena.
- **PersistentMonoSingleton<T>**: Extensión de `MonoSingleton` que utiliza `DontDestroyOnLoad` para persistir entre escenas.
- **Singleton<T>**: Implementación para clases genéricas de C# (thread-safe).
- **Control de Estado**: Seguimiento del estado de inicialización (`None`, `Initializing`, `Initialized`).
- **Samples Incluidos**: Ejemplos prácticos de `GameManager` (persistente) y `SceneGameManager` (volátil).

## Instalación

### Via Unity Package Manager (UPM)
Añade la siguiente línea al archivo `manifest.json` de tu proyecto:

```json
"com.unitycommunity.unitysingleton": "https://github.com/tu-usuario/unity-singleton.git"
```

O importa el archivo `.asmdef` directamente en tu carpeta de Scripts.

## Uso

### 1. MonoSingleton (Para componentes de escena)
Ideal para managers que solo deben existir en una escena específica.

```csharp
public class MySceneManager : MonoSingleton<MySceneManager>
{
    public void DoSomething() => Debug.Log("Trabajando en la escena actual");
}
```

### 2. PersistentMonoSingleton (Para Managers Globales)
Ideal para sistemas de audio, guardado o gestión de red que deben persistir durante todo el juego.

```csharp
public class GameManager : PersistentMonoSingleton<GameManager>
{
    protected override void OnInitialized()
    {
        // Configuración inicial tras crearse el singleton
    }
}
```

### 3. Singleton C# (Sin MonoBehaviour)
Para lógica de datos o servicios que no requieren estar en el árbol de GameObjects.

```csharp
public class DataService : Singleton<DataService>
{
    public string GetData() => "Datos del servicio";
}
```

## Estructura del Proyecto

- **Runtime**: Contiene el núcleo del sistema de Singletons.
- **Samples**: Ejemplos de implementación para entender el flujo de carga y acceso.
- **Tools**: Utilidades adicionales para el flujo de trabajo en Unity.

## API Principal

- `Instance`: Propiedad estática para acceder a la instancia única.
- `InitializeSingleton()`: Método para forzar o personalizar la inicialización.
- `OnInitializing()` / `OnInitialized()`: Hooks protegidos para ejecutar lógica en momentos clave del ciclo de vida.
- `IsInitialized`: Propiedad booleana para verificar el estado.

## Licencia
Este proyecto está bajo la licencia MIT.
