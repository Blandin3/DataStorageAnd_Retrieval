# SCREENSHOT GUIDE - Data Storage and Retrieval

## Required Screenshots for "Scene Update" Criterion (2 points)

You need **progressive screenshots** showing different data point storage and retrieval.

---

## SCREENSHOT 1: ScriptableObject Data Storage Script

**What to capture:**
- The `Playerdata.cs` script showing 3 variables

**Steps:**
1. Open Unity
2. In Project window, navigate to: `Assets/Scripts/Prefs and scripatable/`
3. Double-click `Playerdata.cs` to open in code editor
4. Make sure you can see:
   ```csharp
   public string playerName;
   public int score;
   public float health;
   ```
5. **Take Screenshot** (Windows: Win+Shift+S)
6. Save as: `01_DataStorage_Script.png`

---

## SCREENSHOT 2: ScriptableObject Asset with Data

**What to capture:**
- The ScriptableObject asset in Inspector showing stored values

**Steps:**
1. In Unity Project window, find the ScriptableObject asset
2. Look in `Assets/Scripts/Prefs and scripatable/` or `Assets/Scripts/Data/`
3. Click on the asset (should show in Inspector)
4. Make sure Inspector shows:
   - Player Name: [some value]
   - Score: [some number]
   - Health: [some number]
5. **Take Screenshot** showing both Project window and Inspector
6. Save as: `02_ScriptableObject_Data.png`

---

## SCREENSHOT 3: Control Script Implementation

**What to capture:**
- `PlayerControl.cs` showing how it references and uses the data

**Steps:**
1. Open `PlayerConrtol.cs` in code editor
2. Make sure visible:
   ```csharp
   public Playerdata playerData;
   playerNameText.text = "Player Name: " + playerData.playerName;
   scoreText.text = "Score: " + playerData.score;
   healthText.text = "Health: " + playerData.health;
   ```
3. **Take Screenshot**
4. Save as: `03_Control_Script.png`

---

## SCREENSHOT 4: GameObject with Control Component

**What to capture:**
- GameObject in Hierarchy with control script attached and references assigned

**Steps:**
1. In Unity Hierarchy, find GameObject with `PlayerControl` component
2. Click on it to show in Inspector
3. Make sure Inspector shows:
   - PlayerControl component
   - Player Data field assigned (reference to ScriptableObject)
   - Player Name Text assigned
   - Score Text assigned
   - Health Text assigned
4. **Take Screenshot** showing Hierarchy + Inspector
5. Save as: `04_GameObject_Setup.png`

---

## SCREENSHOT 5: Game View - Initial State

**What to capture:**
- Game running showing UI with data displayed

**Steps:**
1. Click Play button in Unity
2. Switch to Game view
3. Make sure visible:
   - Player Name displayed
   - Score displayed
   - Health displayed
4. **Take Screenshot**
5. Save as: `05_Game_Initial.png`

---

## SCREENSHOT 6: PlayerPrefs Storage Script

**What to capture:**
- `PlayerPrefsManager.cs` showing PlayerPrefs implementation

**Steps:**
1. Open `PlayerPrefsManager.cs` in code editor
2. Make sure visible:
   ```csharp
   PlayerPrefs.GetFloat("Health", 100f);
   PlayerPrefs.GetString("PlayerName", "Ken");
   PlayerPrefs.GetInt("Score", 0);
   PlayerPrefs.SetFloat("Health", health);
   ```
3. **Take Screenshot**
4. Save as: `06_PlayerPrefs_Script.png`

---

## SCREENSHOT 7: Game View - Data Changing

**What to capture:**
- Game running showing data updating in real-time

**Steps:**
1. Keep game running (from Screenshot 5)
2. Wait 5-10 seconds
3. Observe:
   - Health decreasing
   - Score increasing
4. **Take Screenshot** showing changed values
5. Save as: `07_Game_DataUpdate.png`

---

## SCREENSHOT 8: Scene View with UI Setup

**What to capture:**
- Scene view showing UI Text elements connected to data

**Steps:**
1. Stop Play mode
2. Switch to Scene view
3. Select Canvas or UI GameObject
4. Show both Scene view and Inspector with:
   - UI Text components visible
   - References to control scripts
5. **Take Screenshot**
6. Save as: `08_Scene_UI_Setup.png`

---

## FINAL CHECKLIST

For **Excellent (2 points)**, your screenshots must show:
- ✅ Data storage script with 3+ variables
- ✅ ScriptableObject asset with stored data
- ✅ Control script implementation
- ✅ GameObject with component references assigned
- ✅ Game view showing initial data
- ✅ PlayerPrefs implementation
- ✅ Game view showing data updating
- ✅ Scene setup with UI elements

**Minimum 6-8 progressive screenshots showing the complete data storage and retrieval flow.**

---

## Quick Capture Order:

1. Code: Data storage script
2. Inspector: ScriptableObject with data
3. Code: Control script
4. Inspector: GameObject setup
5. Game: Initial state
6. Code: PlayerPrefs script
7. Game: Data updating
8. Scene: UI setup

Save all screenshots in a folder named `Screenshots` for easy submission.
