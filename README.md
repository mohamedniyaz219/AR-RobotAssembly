# 🤖 AR Robot Assembly Kit (Unity + AR Foundation)

An interactive Augmented Reality (AR) application where users manually assemble a robot from exploded parts. Designed for educational, interactive, or gamified learning experiences in mobile AR.

> 📲 Built with Unity 2022.3 LTS + AR Foundation + ARCore  
> 🧑‍🔧 Drag parts, snap them into place, and double-tap to bring your robot to life!

---

## 🚀 Features

- ✅ Exploded view of robot parts on start
- 🧲 Drag-and-drop snapping logic with colliders
- 📍 Snap-to-target with distance detection
- ✌️Trigger robot animation on assembly complete
- 🔁 Works on Android ARCore-supported devices

---

## 🛠️ Tech Stack

| Tool / Package      | Purpose                          |
|---------------------|----------------------------------|
| Unity 2022.3.x (LTS)| Game engine                      |
| AR Foundation       | Cross-platform AR support        |
| ARCore XR Plugin    | Android AR runtime               |
| C#                  | Scripting interaction logic      |
| TextMeshPro         | UI components (buttons, labels)  |

---

## 📁 Folder Structure
Assets/
├── Animations/ # Animator controller + animation clips
├── Models/ # Sentry robot model & prefab parts
├── Prefabs/ # Snap targets and robot components
├── Scenes/ # Main AR scene
├── Scripts/ # DragAndSnap, GameManager, ExplodeController
└── UI/ # Canvas, Buttons, EventSystem

---

## 🧩 How It Works

1. User sees robot parts in exploded view
2. Drags and drops parts to their snap targets
3. When all parts are assembled, robot performs animation

---

## 📱 Deployment (Android)

### Prerequisites

- Unity 2022.3.x LTS
- Android device with ARCore support
- Developer mode + USB Debugging enabled

### Build Steps

1. Switch platform to Android in `Build Settings`
2. Enable ARCore in `XR Plugin Management > Android`
3. Set `Minimum API Level` to **Android 7.0**
4. Go to `File > Build & Run` to deploy APK to your phone

---

## 🧠 Credits

- Sentry Robot model: Unity Asset Store (free)
- Built by Mohamed Niyaz A  
- Guided and debugged using ChatGPT 🤖

---

## 🔐 License

This project is open source and free to use for educational or non-commercial projects. Please give credit if you use the robot model or clone this template.

---

### 🌟 Like this project? Leave a ⭐ on GitHub!

