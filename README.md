# Unity Packages & Utilities

[![Unity](https://img.shields.io/badge/Unity-2021%2B-black?logo=unity)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-10.0-purple?logo=csharp)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

A collection of reusable Unity utilities covering common architecture patterns and editor productivity tools. Designed to be dropped into any project via UPM or manual install.

---

## 📦 What's included

### 💎 Singleton System

Thread-safe Singleton implementations for Unity — covering both MonoBehaviour and plain C# classes.

| Class | Use case |
|---|---|
| `ISingleton` | Base interface — enforces consistent structure |
| `MonoSingleton<T>` | Scene-scoped singleton, destroyed on scene change |
| `PersistentMonoSingleton<T>` | Global manager, survives scene loads (`DontDestroyOnLoad`) |
| `Singleton<T>` | Pure C# singleton, thread-safe, no MonoBehaviour dependency |

All implementations track initialization state (`None` → `Initializing` → `Initialized`) to prevent double-init bugs.

**Usage:**

```csharp
public class GameManager : PersistentMonoSingleton<GameManager>
{
    protected override void OnInitialized()
    {
        Debug.Log("GameManager ready.");
    }
}

// Access from anywhere:
GameManager.Instance.DoSomething();
```

---

### 🛠️ Editor Tools (`/Tools`)

Custom Editor menu extensions to automate common Unity project setup tasks.

- **Create Default Folders** — `Tools > Setup > Create Default Folders`  
  Generates the standard `_Project/Scripts`, `Art`, `Scenes`, `Prefabs` structure in one click.
- **Manifest Sync** — Pulls and replaces `manifest.json` directly from a GitHub Gist.
- **Quick Package Install** — One-click install for Input System, Post Processing, and Cinemachine from the top menu.

---

### 📄 Text File Reader (`/Text file reader`)

A lightweight component for reading and parsing text assets at edit-time or runtime.

- Assign any `TextAsset` and the component automatically splits it into a `string[]` by line.
- Uses `OnValidate` for instant Inspector preview — no need to enter Play Mode to verify the data.

---

## 🚀 Installation

**Option A — Via UPM (Git URL):**

In Unity: `Window > Package Manager > + > Add package from git URL`:

```
https://github.com/NicoRuedaA/Unity-Packages.git
```

**Option B — Manual:**

Clone or download the repo and copy the desired folder into your project's `Assets/` directory.

---

## Project Structure

```
Unity-Packages/
├── Tools/                  # Editor menu extensions
│   ├── FolderSetup.cs      # Default folder creator
│   ├── ManifestSync.cs     # manifest.json updater
│   └── QuickPackages.cs    # One-click package installer
├── UnitySingleton/         # Singleton implementations
│   ├── ISingleton.cs
│   ├── MonoSingleton.cs
│   ├── PersistentMonoSingleton.cs
│   └── Singleton.cs
└── TextFileReader/         # Text asset component
    └── TextReader.cs
```

> Note: Folder names may vary slightly — check the repo tree for the actual structure.

---

## Context

Built to solve repetitive setup tasks across multiple Unity projects. The Singleton system in particular was extracted from production use in [Mobalike](https://github.com/NicoRuedaA/Mobalike) to be reusable across projects.

---

## License

MIT — free to use in personal and commercial projects.

---

Developed by [Nico Rueda](https://github.com/NicoRuedaA)
