# COMP313 Assignment 1

## Ryan Cherry - 300339331

### Procedural Content

[Prototype Demo](https://youtu.be/qjNHtvyqAdI)

Procedural Content is where an algorithm is used to generate game content 
randomly without having to make them all manually before hand.

Early Procedural Generation would try to be very simple, in order to save on computing power and memory. It was a method that some games used in order to save on disk space,
as there wasn't enough room for them to put proper levels into the game. There were many different approaches to procedural generation algorithms, but the main part of it is
that an algorithm generates an object, a map, or a character. This algorithm is then used at run time to populate the game with randomized objects. 

With modern games not needing to worry about memroy/disk space, the need for Procedural generation as a space saver has faded. However, it is now used in games where the emphasis
is on the randomness of the levels. There hasn't been many changes to the way procedural generation has been done, algorithms have become a lot more sophisticated as games 
such as Minecraft have come out, but its still an algorithm that generates random content for a video game. 

In my demo of Procedural Content, an algorithm generates each level, meaning that every time the player enters a new level, it is completely randomly generated. The random 
components are the layout of the map (including food, walls, and enemies), and the tiles that are used to display. There are 8 different wall tiles, 8 different floor tiles, and
3 different outer wall tiles. The map generation algorithm randomly selects a tile to use, and populates the level with all the objects. In the video I show me tinkering with
the generation algorithm a little bit. The first clip is of the default generation algorithm. In the second I increased the amount of walls that will spawn in the level. In 
the final clip, I decreased the amount of walls, and the amount of food that spawns. 

##### How the algorithm works:

This is a very simple demonstration of Procedural Content. It works by by just using a for loop, that populates the middle of the map, leaving an outer ring empty. The double for
loop places walls, food, and enemies inside the level. 

When placing down a tile, it randomly selects from the available prefabs for each object. (8 walls, 8 floors, 3 Outer walls). This makes each level look different, and will make new 
levels each time. 

#### Other Examples

* Minecraft (World)
* Binding of Issac (Levels)
* Terraria (World)
* Diablo 3 (Enemies)
* Spore (Creatures, Worlds, and more)

#### Sources 

Made with Unity using the 2D Roguelike Tutorial: 

Everything used to demonstrate this technology was obtained from the Unity Asset Store. 

[Tutorial](https://unity3d.com/learn/tutorials/s/2d-roguelike-tutorial)

[Asset Store](https://www.assetstore.unity3d.com/en/?&_ga=2.36880231.693987245.1535021252-446590656.1531972195#!/content/29825)
