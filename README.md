# Unity Data Persistence Implementation

This project demonstrates two distinct approaches for managing and displaying persistent data in Unity: **ScriptableObjects** and **PlayerPrefs**.

---

## 1. ScriptableObjects Approach

**Overview:**  
ScriptableObjects provide a way to create data containers as reusable assets that exist independently from scene GameObjects. This implementation uses `Playerdata` to manage player information.

**Implementation Files:**
- `Playerdata.cs` – ScriptableObject definition containing `playerName`, `score`, and `health` properties.
- `PlayerControl.cs` – Controller component that retrieves data from the ScriptableObject and refreshes the UI display.

**Implementation Steps:**
1. Generate a ScriptableObject asset through **Assets → Create → ScriptableObjects → Sample Safe House**.
2. Configure the `playerName`, `score`, and `health` fields within the Inspector panel.
3. Add the `PlayerControl` component to a GameObject and link the ScriptableObject asset along with UI Text components.
4. Enter **Play Mode** – the interface will reflect the data stored in the ScriptableObject.

**Key Features:**
- Stores 3 data points: player name (string), score (integer), and health (float)
- Data persists as an asset file in the project
- Easy to edit values in the Inspector without code changes
- Reusable across multiple scenes

---

## 2. PlayerPrefs Approach

**Overview:**  
PlayerPrefs provides a simple key-value storage system for persisting data across game sessions. This example showcases dynamic data updates with three tracked variables.

**Implementation Files:**
- `PlayerPrefsManager.cs` – Manages `playerName`, `score`, and `health` through PlayerPrefs API. Clears previous session data on initialization for testing purposes.

**Implementation Steps:**
1. Set up UI Text components for displaying Health, Score, and Player Name.
2. Attach the `PlayerPrefsManager` component to a GameObject and connect the UI Text references.
3. Enter **Play Mode**:
   - Health value decreases continuously (starts at 100, decreases by 5 per second)
   - Score value increases continuously (increases by 50 per second)
   - Player Name displays as "Blandine"
4. All changes are automatically persisted using PlayerPrefs.
5. Restarting the application triggers data reset via `PlayerPrefs.DeleteAll()`.

**Key Features:**
- Stores 3 data points using key-value pairs
- Data automatically saves to system registry (Windows) or preference files (Mac/Linux)
- Real-time updates visible in the game view
- Demonstrates both data retrieval (GetFloat, GetString, GetInt) and storage (SetFloat, SetString, SetInt)

---

## Project Structure

```
Assets/
├── Scripts/
│   ├── Data/
│   │   ├── PlayerData.cs
│   │   └── PlayerDataDisplay.cs
│   └── Prefs and scripatable/
│       ├── Playerdata.cs
│       ├── PlayerConrtol.cs
│       └── PlayerPrefsManager.cs
└── Scenes/
    ├── DataStorage.unity
    └── Prefs.unity
```

---

## Comparison

| Feature | ScriptableObjects | PlayerPrefs |
|---------|------------------|-------------|
| Storage Location | Project asset file | System registry/preferences |
| Persistence | Editor + Build | Build only |
| Editability | Inspector (easy) | Code only |
| Use Case | Game configuration, static data | Player progress, settings |
| Data Types | Any serializable type | String, Int, Float only |

---

## How to Run

1. Open the project in Unity
2. Open either `DataStorage.unity` or `Prefs.unity` scene
3. Press Play to see data storage and retrieval in action
4. Observe UI updates showing stored data values
