# Snow Surfer

<img src="docs/img/..." width="240" height="400" alt="Snow Surfer Gameplay">

## Description

....
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

## 🛠 Building for iOS (Mac Users)

Generating an iOS build requires local regeneration on a Mac. Do not use build folders committed from Windows.

---
### A. Configure Build Settings

#### 1. Go to File > Build Settings and select iOS.
![file>build_setting.png](docs/img/file%3Ebuild_setting.png)


#### 2.Click Player Settings... > Other Settings.
![player_setting.png](docs/img/player_setting.png)
![other_setting.png](docs/img/other_setting.png)

3. **Target SDK Selection:**
![target_sdk.png](docs/img/target_sdk.png)

* Set to **Device SDK** for a physical iPhone.
* Set to **Simulator SDK** for the Xcode Simulator.
4. Click **Build** and choose a folder name (e.g., `Build_iOS`).
![build.png](docs/img/build.png)
