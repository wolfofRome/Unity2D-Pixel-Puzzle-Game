# GroupAA-Unity2D-Pixel-Puzzle-Game

## 1. Group Information

**Group ID:** Group AA

**Group members:**

- Jianxiang Gao
- Ruyun Zhang
- Ziheng Gong

## 2. Project description

**Game name:** **"Lost Castle"**

![](https://github.com/JianxiangGao/GroupAA-Unity2D-Pixel-Puzzle-Game/blob/main/cover.png)

**Git repository URL:** https://github.com/JianxiangGao/GroupAA-Unity2D-Pixel-Puzzle-Game

**Gameplay video URL:** 

**Concept Statement:** 

- Game type: This is a pixel game. The pixel style gets rid of people's social aesthetic fatigue. Compared with the reality that a large number of games are constantly pursuing, the simple and casual style will attract the needs of players more.

- It is also a puzzle-solving adventure game, which requires players to analyze and process the information and plots that appear in the game, and then find clues to solve various puzzles. Therefore, Players can look for the "truth behind" step by step during the game and get an immersive gaming experience.

- Game background: The background story of the game will not be displayed in text form at the beginning of the game, but will be interspersed in the whole game in clues combined with puzzles, which can better improve the player's gaming experience.

## 3. How to Play

(Unity version: 2020.1.6f1)

- File -> Build Settings (in order): Menu -> Opening Scene -> Floor00 -> Floor01 -> Floor02 -> End

- The window ***Game*** -> Display -> Standalone(1920*1080)

- Assets -> Scenes -> ***Menu***, Run the ***Menu*** firstly

- The menu in the game provides basic operation buttons:

  WASD (walking)

  Space (interact)

  B (backpack)

  other buttons will be prompted in the game dialogue

## 4.  Feature List
### Environment

- **Levels:** The entire game contains 6 scenes, three of which are the main map of the game (Floor00, Floor01, Floor02), an initial menu (Menu), and two cutscenes (Opening Scene, End).
- **Maps:** The map material uses free pixel materials and is drawn using Tile Palette. The map is divided into 5 layers (Shadow, Ground, Wall, Furniture, Decoration) to better cover the material pictures.

### Gameplay features

- **Dialogue system:** The character can interact with interactive objects (press the Space button). Create a Dialogue Panel in the Canvas under each scene, and control whether the panel and text can be displayed through the DialogueManager Script.
- **Character movement:** Add the actual movement to the game object, then add the animation to the character based on that movement. Use Animation's track loop to play actions to achieve the dynamic effect of movement.
- **Backpack system:** Players can collect items by touching the pickable items in the game world. Press the B button to open the backpack to view the number of collected items, and click on the item to view the item description.
- **Monster AI tracking:** The monster (the bat in the game) uses the A* algorithm to track the player through AI, thereby increasing the difficulty and interest of the game.
- **Open/close the door:** Doors inside the castle which requires keys to open. Only after obtaining certain keys could player open the door.
- **Photo Rotate Puzzle Game:** Use transform.Rotate(0f, 0f, 90f) to click on the picture to rotate the picture. The success is determined by whether rotation.z is equal to 0. A clue can be obtained after completing the puzzle game.
- **Drag/Drop Puzzle Game:** Use Vector3.Distance to realize the mosaic process, and determine whether the objects are consistent through the coordinates of the initial position and the current position. A clue can be obtained after completing the puzzle game.

### Non-playable features

- **Cutscenes:** Combining pixel background images and dialogue functions in the new scene to complete the opening cutscene of the story narrative form. Realize the cutscene at the end of the game in the same way.
- **Scene switching:** When the player walks to a specific area (that is, the stairs), you can press the E key to enter the next scene according to the prompt of the dialogue.
- **Scene loading progress bar:** When entering another layer, there will be a scene loading interface, showing the current scene loading progress and game Tips. When the scene is loaded, the player will be prompted to press Space to enter the next scene.
- **Pause game menu:** Players can open the game pause menu by clicking the exclamation mark in the upper right corner during the game. The pause menu includes three functions: "Resume Game", "Operation Instructions", and "Adjust Game Volume".
- **Operation instruction interface:** The player can enter the operation instruction interface from the pause menu to view the player's operation guide.
- **Game start menu:** The Game Start Menu has a fade-in effect. The player clicks the "new start" button to enter the game and clicks the "cancel" button to exit the game.
- **Diary:** There are 8 diaries in the game. This is the most direct way to understand the background story of the game.

### Audiovisual

- **Camera:** realize smooth camera movement through smoothSpeed*Time.deltaTime, and limit the maximum range (x and y values) that the camera can move according to the map size.
- **Audio:** There are three types of background music in the game, which are located in the Menu scene, Opening Scene and three Floor Scenes. When the characters switch scenes, there is a special sound effect.
- **Light:** The whole game is based on dark colours, candles and torches have their own point lights.