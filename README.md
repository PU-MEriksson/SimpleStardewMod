# SimpleStardewMod

A simple SMAPI mod for Stardew Valley that lets the player toggle a speed boost on and off using the **K** key.

## 🌟 Features

- Toggle a custom speed boost on or off at any time by pressing **K**
- Default normal speed: **5**
- Default boosted speed: **10**
- Works in any point of the game (outside cutscenes or dialogs)
- Logs toggle events in the SMAPI console

## 📦 Requirements

- **Stardew Valley** (Steam, GOG, or other)
- **SMAPI** 3.18 or newer
- **.NET 6.0 SDK** installed on your machine

## 🛠 Installation

1. Download or clone this repository into your **MLD** folder:

   ```text
   %AppData%/StardewValley/Mods/SimpleStardewMod
   ```

   Or on Mac/Linux:

   ```bash
   ~/.config/StardewValley/Mods/SimpleStardewMod
   ```

2. Ensure the compiled `` and `` are present in the mod folder.

3. Launch Stardew Valley via SMAPI.

## 🚀 Usage

- Press **K** in‑game to toggle the speed boost:
  - **ON**: Your movement speed increases from 5 to 10.
  - **OFF**: Speed returns to normal (5).
- Check the SMAPI console logs for feedback:
  ```
  SimpleStardewMod: Speed boost ON (speed = 10)
  SimpleStardewMod: Speed boost OFF (speed = 5)
  ```

## 📝 Code Overview

- **ModEntry.cs**: Contains the main mod logic:
  - Subscribes to `Input.ButtonPressed` and `GameLoop.UpdateTicking`.
  - `OnButtonPressed` toggles a boolean flag when **K** is pressed.
  - `OnUpdateTicking` applies the current speed setting each game tick.

## 📄 manifest.json

Make sure your `manifest.json` matches the mod folder name. Example:

```json
{
  "Name": "SimpleStardewMod",
  "Author": "YourName",
  "Version": "1.0.0",
  "Description": "Toggle a speed boost in Stardew Valley.",
  "UniqueID": "yourname.simpleStardewMod",
  "EntryDll": "SimpleStardewMod.dll",
  "MinimumApiVersion": "3.18.0"
}
```

## 🧑‍💻 Development Background

This mod was created as part of a learning exercise. Initially, the [official SMAPI modding tutorial](https://stardewvalleywiki.com/Modding\:Modder_Guide/Get_Started) was followed to set up a basic mod. Afterwards, additional guidance was provided by ChatGPT to implement and refine the speed‑toggle feature, and to understand how Stardew Valley mods work under the hood.

The main purpose of this project is educational: to explore SMAPI’s API, event system, and content‑editing features in a hands‑on way.

## 🤝 Contributing & License

This mod is provided as-is for educational purposes. Feel free to modify and use it in your own mods or projects. If you share or adapt this code, please provide attribution.


