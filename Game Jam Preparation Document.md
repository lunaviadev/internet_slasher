# Game Jam Preparation Document

## Overview
The goal is to create a 2D Unity game inspired by *Neon White*. The game will emphasize fast, stylish gameplay with a focus on tight controls, flashy visuals, and a strong sense of flow. The theme of the game jam is not yet known, but the foundation should be flexible enough to adapt to any theme.

## Core Gameplay Direction
- **Twin-stick shooter foundation**  
  The player moves with WASD and aims/shoots with the mouse. Movement should feel responsive, with acceleration and deceleration to provide weight.
  
- **Movement-based abilities**  
  Incorporate high-mobility mechanics such as dashes, wall jumps, or teleportation. Abilities should enhance both combat and movement flow.

- **Ability cycling system**  
  Similar to *Neon White*, abilities can be used in two ways:
  - Normal use (e.g., shooting, throwing, or skill activation).
  - Discard use (e.g., dash, area attack, or teleport).  
  Abilities could be distributed randomly or earned through pickups, adding a roguelite element.

- **Fast-paced arena structure**  
  Levels should be designed for short, high-intensity sessions. Players clear waves of enemies in an arena, and upon completion, an exit opens to the next stage. A timer and scoring system can encourage replayability and speedrunning.

## Prototype Features to Build Early
1. **Player Controller**
   - 8-direction movement using WASD.
   - Mouse-aimed shooting.
   - Dash mechanic with invulnerability frames.
   - Acceleration and deceleration for smooth movement.

2. **Ability System**
   - Implement a `ScriptableObject` for abilities.
   - Each ability should define two actions:  
     - Fire/Use.  
     - Discard/Alternate use.
   - Player maintains a hand of abilities, cycling through them as needed.

3. **Enemy and Spawner System**
   - Basic AI: chase player and optionally shoot.
   - Enemy spawners for wave-based encounters.
   - Prefab-based system for easy expansion.

4. **Arena Loop**
   - Defeat all enemies to unlock the exit.
   - Boss at the end of a sequence of levels.
   - Timer and scoring system to reward speed and efficiency.
   - Level transition system to chain arenas together.

## Visual and Stylistic Goals
- Pixel art graphics with high-contrast, vibrant palettes.
- Visual effects for player actions:
  - Screen shake on impactful events.
  - Afterimages for dashes or fast movement.
  - Flash and glow effects on abilities.
- Enemy attack patterns resembling bullet-hell mechanics.

## Scope and Framing Options
Depending on the game jam theme, possible frames for the project include:
- **Arena runs with discard-based abilities** (similar to a hybrid of *Enter the Gungeon* and *Neon White*).
- **Stylish roguelite combat** emphasizing chaining combos of movement and attacks.
- **Timed stage-based shooter** where the goal is to complete levels as quickly and efficiently as possible.

## First Steps
- Begin prototyping movement, shooting, and the ability system prior to the jam.
- Prepare a simple enemy prefab and spawner to test combat flow.
- Build a basic arena loop to ensure gameplay feels complete at an early stage.
