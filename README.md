# GamesEngine1Project
A repository for the submission of my Games Engine 1 module project

My Idea for the project is a generated maze in unity. I hope to be able to start the level and a maze will be automatically made, different to each time it is played, later into the development i may start adding in things to make it more like a little game but to start i just want a program that creates a maze. I got my idea from halloween, thinking about corn mazes they do around then and it fits the requirement of something generated with enough room for some creativity as well.

Also into the development a bit if i get it working I will continue to tinker with it and make it more of a creative experience, IE utilising audio-visuals, colour changing assets, etc. maybe even including some enemies to contend with.

## Description:
A procedurally generated maze, created with an algorithm that creates a 2D grid of characters depicting empty space and walled areas, it then creates a quad based off parameters fed to it, such as hallway width and hallway height which determine the size of the hallways in the maze, this quad is made with a meshcollider and a material of the developers choice, for this I used the shaders we learnt about and implemented in the labs.

The 2D grid of characters data is used to generate sets of quads that arrange themselves to fill the walled areas and leave out the empty space, this generates the maze. After the Maze is generated a 3rd Party tool called Pathfinder 3D scans a set area for meshcolliders and the "forbidden" tag and creates a 3D grid of boxes around all the objects containing these. This allows the Pursuer object, in this case an enemy octopus I altered from the Labs, to find the player and make it's way through the maze to get to the player.

It would be intended that the AI be improved of this octopus and that it would continously follow the player but as of now it is unfinished and will just draw a ray to the player and follow this ray at the moment the grid is finished being created.

Aside from the generated Maze and the Generated Enemy octopus there is also 100 fish with simple AI, these fish will flock together and move around the map following a target when flocking, when not flocking they will simply travel and group when they become close together, at the moment the maze is too large, so they rarely flock in a majorly visible way, however they do look aesthetically pleasing and go with the mood I was trying to create with the game, Improvements to these would include avoidance of the player character and massive avoidance of the enemy squid, as well as a way to make them stop travelling through walls, although this has it's own pleasing visuals.

## WARNINGS
This maze is quite large, to make it run better there is code which selects the size of the maze in one of the maze files which can reduce the size, because of this the program doesnt run the best it could, and this can cause motion sickness with framerate drops.

The shader chosen for the floor and roof are only temporary and also could cause Motion Sickness because they move.

The user should wait on start, as the pathfinding AI causes some lagging for a few seconds as it detects all objects in the scene and determines what it should avoid

Sometimes the pathfinder simply can't find the right way and the enemy squid will be found at the goal of the maze just waiting.

## NOTES
This is unfinished because of time constraints, git commits are also low because of setting up the gitignore wrong to begin with so I would have to close unity every time I would wish to commit, there was a lot of work in each commit however.

This project requires VR, there is not fps controller properly implemented although it was intended to be later.

A lot of the work was taken from other sources, such as tutorials and labs, however it was a lot of work to understand these separate assets and tie them all in together properly and understand why some would not work at times and resolve those issues, for instance the pathfinding AI would not work because the maze was generated after it was, to resolve this I created a GameController to control all the other controllers and run them in the correct order.

There was an attempt to use blender but it was too hard and time consuming.

## INSTRUCTIONS
When the program is cloned, there is a zip folder inside with the executable, run this and it should immediately place the user into the maze, it will lag for a few seconds before levelling out. the user should see a green line finding its way to them, this is the ray the Octopus has drawn, it will begin moving towards the end of the line following the path, the reason this debug tool was left in is to make it easier for the test user to find their way to the goal and to see if the octopus is finding new paths as the player is moving, although this shouldn't be the case yet.

As of now there is no defined end to the game, the user may wander the corridors of the maze and watch the fish, or find the yellow goal box, but it would have been intended that the octopus be slowed down, able to find the user as they are moving, and if caught it would end the users go on that maze, if the user was to get to the goal before the octopus got to them then they would win.

Please Note that this application is definitely going to cause motion sickness with extended use.

## Video Demo Link
https://youtu.be/fWEHgpY1PWY

### References:
Maze Generation
https://www.raywenderlich.com/82-procedural-generation-of-mazes-with-unity

Fish Flocking
https://www.youtube.com/watch?v=eMpI1eCsIyM

PathFinding AI
https://assetstore.unity.com/packages/tools/ai/pathfinder-3d-100285?aid=1100l355n&gclid=Cj0KCQiAlZH_BRCgARIsAAZHSBkDJJWG_RLO9RFYrSTirBFke_bUNqcLg-NeN2pOeQzdbPb6N9-QMmUaAiBjEALw_wcB&pubref=UnityAssets%2ADynNew06%2A1723478829%2A67594162255%2A336302017355%2Ag%2A%2A%2Ab%2Ac%2Agclid%3DCj0KCQiAlZH_BRCgARIsAAZHSBkDJJWG_RLO9RFYrSTirBFke_bUNqcLg-NeN2pOeQzdbPb6N9-QMmUaAiBjEALw_wcB&utm_source=aff
