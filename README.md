# Snow Surfer
🎮 [Play the game online](https://yourname.itch.io/snow-surfer)

<img src="docs/img/..." width="240" height="400" alt="Snow Surfer gameplay">

## Description
Snow Surfer is a 2D arcade game built in Unity that focuses on responsive movement and speed control through player input. The project uses Cinemachine for a player-follow camera, Unity’s Input System for action-based input handling, and a speed system driven by continuous input.

The game also includes simple particle effects for player feedback and a basic flow to handle crash and level completion states.

---
## 🚀 Features
* **Player-Follow Camera**: Smooth camera tracking using Cinemachine, tuned for high-speed movement.
* **Modern Input System**: Action-based input handling for movement and continuous speed control.
* **Dynamic Speed Control**: Acceleration and deceleration driven by held input, with balanced speed limits.
* **Gameplay Feedback Effects**: Event-driven particle effects triggered on crash and level completion.
* **Level Design with Sprite Shape**: Smooth, spline-based track creation for rapid iteration and clean collisions.

---
## Project Setup

Before you start, ensure you have the following installed:

* **Unity Hub**
* **Unity Editor 6000.3.2f1**
* **Git LFS** (Required for large library files)

> [⚠️!IMPORTANT]
> This project uses **Git LFS** to store large binary files. If you clone without Git LFS installed, your build files will be corrupted. Install it via `brew install git-lfs` (Mac) or `sudo apt install git-lfs` (Linux) and run `git lfs install` before cloning.

### 1. Clone the Repository
you need to clone this repository first, copy paste this command below to your terminal:
```zsh
git clone https://github.com/angellee177/snow_surfer.git
```

Then goto the folder.
```zsh
cd snow_surfer
```

### 2. .NET Environment

Unity scripts require the .NET SDK for IntelliSense. Check your version:

```zsh
dotnet --version
```

If not found, download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

### 3. Open with Unity

1. Open **Unity Hub** and click **Add**.
2. Select the `snow_surfer` folder.
3. Click the project to open.

> [⚠️ WARNING] <br>
> If you see a "Safe Mode" warning or compilation errors regarding `UnityEngine.InputSystem`, go to **Window > Package Manager**, search for **Input System**, and click **Install**. Unity will restart to enable the new back-ends.

---
