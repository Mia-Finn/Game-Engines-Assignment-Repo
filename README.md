# Game Engines Assignment Repo

Name: Amelia Finnerty

Student Number: C21341136

Class Group: TU984 Game Design Year 3

Video: [![YouTube](http://img.youtube.com/vi/ipXY7mvgeto/0.jpg)](https://youtu.be/ipXY7mvgeto)]

# Description of the project
My metaverse idea is an interactive campfire scene where the player has the opportunity to explore the scene in Unity 3D while interacting with various aspects of the worlds envionment. There are many ways to experience this world, the player can listen to some music while playing around at the campfire or simply watching it burn, or they can opt to simply take in the scene without the music and only the sounds of the fire and the surrounding nature.

This project was made in the Unity Game Engine, it currently only plays on PC in as a 3D Unity scene, not yet working in VR. There is a low-poly/cartoon like art style to the scene.

# Instructions for use
Use the W, A, S, D keys to move in the game world and move the mouse to look around.
The player can use 'E' to interact with most objects in the campfire scene. Players can interact with the radio, the tablet and the marshmallows.
Holding down left mouse button will pick up objects and letting go will drop them. Players can press the right mouse button while holding an object to throw it.
The 'Esc' button will bring the player to the main menu where they can control the volume as well as the controls menu.

# How it works
The character movement script makes use of Unity's built in input system. 

The majority of the project is handled in my Scene Manager script. This script looks out for the collision of objects and the distane between objects and then 'if' statements control what will happen as a result, for example if the player gets to close to the fire then the 'Be Careful!' text line will appear but if they get closer and walk into the fire, they will get teleported back to their spawn point. This script also controls the interactions with objects.

The buttons on the radio control the music using the built in Unity UI button functions. The volume is controlled with a slider and a script that saves the last volume setting to player prefs.

# List of classes/assets in the project

| Class/asset | Source |
|-----------|-----------|
| sceneChange.cs | Self written |
| playerMovement.cs | Modified from a class script |
| mouseLook.cs | Modified from [reference](https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/) |
| cursorSelect_script.cs | Self written |
| tesPromptScript.cs | Self written |
| ObjPickup.cs | Modified from [reference](https://youtu.be/FnE4aS0dsE4?si=ire21gDw-Zz5evm2) |
| changeSkybox.cs | From [reference](https://www.youtube.com/watch?v=HAvHeIBVyvY) |
| radioScript.cs | Self written |
| roastMarshmallowScript.cs | Self written |
| volumeManager.cs | From [reference](https://www.youtube.com/watch?v=yWCHaTwVblk) |
| FREE Skybox Extended Shader | Unity Asset Store |
| All level decorations (logs, rado, marshmallows, etc.) | Self made |
| Fire particle system | Modified from [reference](https://youtu.be/PoMl09d1Avc?feature=shared) |
| All fonts | From [Dafont.com](https://www.dafont.com/) |
| Song 1 | Music from [Youtube](https://youtu.be/6wM5GJVwgJo?si=UY8LGB73XAdgbWhY) |
| Song 2 | Music from [Youtube](https://youtu.be/2WXAZhsDPqo?si=GHZM_vFkrG-328vO) |
| Song 3 | Music from [Youtube](https://youtu.be/v6ELNT542-I?si=bI_3q57LGkVLNTQv) |
| Song 4 | Music from [Youtube](https://youtu.be/5PlRX4671o0?si=UCfcTw9VmYVnVfff) |
| Fire noise | Sound from [Freesound.org](https://freesound.org/people/Ambient-X/sounds/660298/) |
| Day scene background noise | Sound from [Freesound.org](https://freesound.org/people/klankbeeld/sounds/524001/) |
| Night scene background noise | Sound from [Freesound.org](https://freesound.org/people/Dokuta_Gerovv/sounds/662095/) |

# References
* Player movement script was modified from old class notes
* Mouse look script from r/Unity3D on Reddit - https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/
* Object pickup and drop script video from Omogonix on Youtube - https://youtu.be/FnE4aS0dsE4?si=ire21gDw-Zz5evm2
* Change skybox script video from Cezary_Sharp on Youtube - https://www.youtube.com/watch?v=HAvHeIBVyvY
* Fire particle system references - [Video](https://youtu.be/PoMl09d1Avc?feature=shared) , [Unity Learn](https://learn.unity.com/tutorial/introduction-to-particle-systems#) , [Unity Docs](https://docs.unity3d.com/ScriptReference/ParticleSystem.html)

# What I am most proud of in the assignment
I am very proud of the radio function. I think that it works really well and I am happy with the way the asset itself looks. I am also quite proud of the fire particle system. I like the colours and the low-poly arty style that it has. I think it fits the rest of the environment really well.

# What I learned
I learned a lot about sound design it Unity. I had never really done too much with game sounds until this project and I'm very happy with hiw they turned out. I also learned a lot about particle systems in Unity. I'd also never done too mush with them so I had to learn how they worked and how I could get it to look the way I wanted it too, luckily I was able to find a lot of material online to help with this (linked above).

# Proposal submitted earlier can go here:
An interactive campfire experience with sounds, music and particle effects. I aim to make it so that you can change the colours of the fire and maybe even the effects too, as well as interact with the other objects in the environment, like roasting marshmallows and choosing some campfire songs to listen to!
