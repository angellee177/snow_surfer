# Snow Surfer
![](https://img.shields.io/badge/2D-orange)
![](https://img.shields.io/badge/No--AI-blue)
![](https://img.shields.io/badge/Singleplayer-yellow)
![](https://img.shields.io/badge/Action-red)
![](https://img.shields.io/badge/Arcade-blue?logo=game)
![](https://img.shields.io/badge/Unity-6000.3.2f1--LTS-gray?logo=unity)
![](https://img.shields.io/badge/C%23-Language-green?logo=csharp)
![](https://img.shields.io/badge/Platform-WebGL-orange)



<img src="img/readme.gif" width="600" height="400" alt="Snow Surfer gameplay">

## Description
Snow Surfer is a 2D arcade game built with Unity that emphasizes responsive movement and real-time speed control through keyboard input. Players influence motion dynamics using acceleration, deceleration, and capped speed limits, creating a physics-driven gameplay experience.

As my third Unity project, this game reflects a deeper understanding of Unity’s 2D systems and experimentation with custom mechanics such as speed boosts on collision, flip-based score multipliers, and real-time speed tracking displayed on screen.

This project demonstrates my growing ability to translate gameplay ideas into functional systems using Unity.

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
* **Unity Editor 6000.3.2f1 LTS**
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
