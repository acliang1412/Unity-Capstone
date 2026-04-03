# Unity 2D Capstone Project
**Developer:** Andy Liang  
**Tech Stack:** Unity 2021.3, C#, Git

## 🚀 Project Overview
This project is a 2D adventure game developed as a Capstone project. It focuses on modular game design, physics-based character controllers, and robust scene management.

---

## 🛠 Completed User Stories

### **User Story 1: Scene Architecture & Navigation**
* **Core Loop:** Created a functional game flow: `Title` -> `Gameplay` -> `Ending`.
* **SceneLoader System:** Integrated a C# SceneLoader to manage transitions and build indices.
* **UI Foundation:** Designed a responsive Canvas scaled for multiple resolutions, including functional **Play** and **Quit** buttons.

### **User Story 2: Player Character & Physics**
* **Player Prefab:** Developed a "Master Template" Player object to ensure consistency across all game levels.
* **Physics Integration:** Implemented **Rigidbody 2D** and **Box Collider 2D** for environmental interaction.
* **Movement Logic:** Created a `PlayerController.cs` script using `Input.GetAxisRaw` for snappy, multi-axis movement.
* **Bug Resolution:** * Fixed **Physics Depenetration:** Resolved an issue where the Player was "ejected" from the Floor at start-up by separating collider bounds.
    * Optimized **Linear Drag & Constraints:** Adjusted Rigidbody settings to prevent drifting and unwanted Z-axis rotation.

---

## 🕹 How to Run
1. Open the project in **Unity 2021.3**.
2. Load the **Title** scene from the `Scenes` folder.
3. Press **Play**.
4. Use **WASD** or **Arrow Keys** to control the Player square.

---

## 📂 Project Structure
* `/Assets/Scripts`: All C# logic including Player and Menu controls.
* `/Assets/Prefabs`: Modular game objects (Player, Floor).
* `/Assets/Scenes`: The three core game states.
