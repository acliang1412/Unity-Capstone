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

---

### **User Story 2: Player Character & Physics**
* **Player Prefab:** Developed a "Master Template" Player object to ensure consistency across all game levels.
* **Physics Integration:** Implemented **Rigidbody 2D** and **Box Collider 2D** for environmental interaction.
* **Movement Logic:** Created a `PlayerController.cs` script using `Input.GetAxisRaw` for snappy, multi-axis movement.
* **Bug Resolution:** * **Physics Depenetration:** Resolved an issue where the Player was "ejected" from the Floor at start-up by separating collider bounds.
    * **Linear Drag & Constraints:** Adjusted Rigidbody settings to prevent drifting and unwanted Z-axis rotation.

---

### **User Story 3: Environment Design & Physics-Based Navigation**
* **Environment Architecture:** Transitioned from Tilemaps to a **Prefab-based "Space Scrapyard"** system for scalable level design.
* **Organizational Hierarchy:** Implemented a container system using Empty GameObjects (`--- BACKGROUND ---`, `--- ENVIRONMENT ---`) to manage 100+ scene objects.
* **Physics-Based Movement:** Rebuilt the `PlayerMovement.cs` controller to handle 360-degree flight using `Rigidbody2D` with tuned **Linear Drag** for space navigation.
* **Dynamic Orientation:** Implemented a rotation algorithm using `Mathf.Atan2` to ensure the ship's nose always aligns with the movement vector.
* **Sorting & Visual Depth:** Established a multi-layer sorting hierarchy (Background at -10, Gameplay at 0, Combat at 5) to ensure visual clarity during intense gameplay.

---

### **User Story 4: The Scrapyard & HUD**
* **Follow-Spawner:** Developed a custom `Spawner.cs` script that tracks the player's position to ensure obstacles always rain down relative to the player's movement on both the X and Y axes.
* **World-Space HUD:** Implemented a floating health bar childed to the Player ship using a **World-Space Canvas**, providing immediate visual focus on remaining health.
* **Collision Logic:** Integrated Tag-based collision detection to differentiate between "Obstacles" (Meteors/Damage) and "Collectibles" (Energy Bolts/Score).
* **Procedural Generation:** Meteor spawn rates, rotation, and positions are randomized via script to increase replayability and maintain a high difficulty curve.

---

## 🕹 How to Run
1. Open the project in **Unity 2021.3**.
2. Load the **Title** scene from the `Assets/Scenes` folder.
3. Press **Play**.
4. Use **WASD** or **Arrow Keys** to navigate the spaceship through the debris field.

---

## 📂 Project Structure
* `/Assets/Scripts`: All C# logic including Player, Spawner, and HUD controls.
* `/Assets/Prefabs`: Modular game objects (Player, Meteors, Collectibles).
* `/Assets/Scenes`: The core game states (Title, Gameplay, Game Over).
