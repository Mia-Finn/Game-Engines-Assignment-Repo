# Game Engines Assignment Repo

Name: Amelia Finnerty

Student Number: C21341136

Class Group: TU984 Game Design Year 3

Video:

[![YouTube](http://img.youtube.com/vi/ipXY7mvgeto/0.jpg)](https://youtu.be/ipXY7mvgeto)

# Description of the project
My metaverse idea is an interactive campfire scene where the player can explore the scene in Unity 3D while interacting with various aspects of the worlds envionment. There are many ways to experience this world, the player can listen to some music while playing around at the campfire and roasting marshmallows, or they can opt to simply take in the scene without the music and only the sounds of the fire and the surrounding nature. It's completely up to you how you choose to experience this campfire!

# Instructions for use
(This project was made in the Unity Game Engine, it currently only plays on PC as a 3D Unity scene, not yet working in VR)

Use the W, A, S, D keys to move in the game world and move the mouse to look around.

The player can use 'E' to interact with most objects in the campfire scene. Players can interact with the radio and the tablet.

Holding down left mouse button will pick up objects and letting go will drop them. Players can press the right mouse button while holding an object to throw it.

The 'Esc' button will bring the player to the main menu where they can control the volume as well as see the controls menu.

# How it works
The character movement script makes use of Unity's built in input system. 

The majority of the project is handled in my Scene Manager script. This script looks out for the collision of objects and the distance between objects, then 'if' statements control what will happen as a result, for example if the player gets to close to the fire then the 'Be Careful!' text line will appear but if they get closer and walk into the fire, they will get teleported back to their spawn point. This script also controls the interactions with objects. This script handles any scene changes and he turning on and of of the canvas' for the menus as well as the cursor.

The buttons on the radio control the music using the built in Unity UI button functions. The volume is controlled with a slider and a script that saves the last volume setting to player prefs.

A lot of the elements of this project use buttons to make something happen in the game world. Many of the scripts contain public voids that are called on when a button is pressed. For example when the player selects either 'Day' or 'Night' in the world edit the buttons access a public void in the changeSkybox.cs script and then change the game's look and it's sounds accordingly.

Code example (this is the void that is used by the 'Day' button):

```C#
 public void dayTime()
    {
        RenderSettings.skybox = dayMaterial;
        nightAudio.SetActive(false);
        dayAudio.SetActive(true);
    }
```

# List of classes/assets in the project

| Class/asset | Source |
|-----------|-----------|
| sceneChange.cs | Self written |
| playerMovement.cs | Modified from a class script |
| mouseLook.cs | Modified from [reference](https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/) |
| cursorSelect_script.cs | Self written |
| tesPromptScript.cs | Self written |
| ObjPickup.cs | Modified from [reference](https://youtu.be/FnE4aS0dsE4?si=ire21gDw-Zz5evm2) |
| changeSkybox.cs | Modified from [reference](https://www.youtube.com/watch?v=HAvHeIBVyvY) |
| radioScript.cs | Self written |
| roastMarshmallowScript.cs | Self written |
| volumeManager.cs | From [reference](https://www.youtube.com/watch?v=yWCHaTwVblk) |
| FREE Skybox Extended Shader | Unity Asset Store |
| All level decorations (logs, radio, marshmallows, etc.) | Self made |
| Fire particle system | Modified from [reference](https://youtu.be/PoMl09d1Avc?feature=shared) |
| All fonts | From [Dafont.com](https://www.dafont.com/) |
| Song 1 | Music from [Youtube](https://youtu.be/6wM5GJVwgJo?si=UY8LGB73XAdgbWhY) |
| Song 2 | Music from [Youtube](https://youtu.be/2WXAZhsDPqo?si=GHZM_vFkrG-328vO) |
| Song 3 | Music from [Youtube](https://youtu.be/v6ELNT542-I?si=bI_3q57LGkVLNTQv) |
| Song 4 | Music from [Youtube](https://youtu.be/5PlRX4671o0?si=UCfcTw9VmYVnVfff) |
| Fire noise | Sound from [Freesound.org](https://freesound.org/people/Ambient-X/sounds/660298/) |
| Day scene background noise | Sound from [Freesound.org](https://freesound.org/people/klankbeeld/sounds/524001/) |
| Night scene background noise | Sound from [Freesound.org](https://freesound.org/people/Dokuta_Gerovv/sounds/662095/) |
| Click noise 1 | Sound from [Freesound.org](https://freesound.org/people/brnck/sounds/257357/) |
| Click noise 2 | Sound from [Freesound.org](https://freesound.org/people/aphom000/sounds/687105/) |

# References
* Player movement script was modified from old class notes
* Mouse look script from r/Unity3D on Reddit - https://www.reddit.com/r/Unity3D/comments/8k7w7v/unity_simple_mouselook/
* Object pickup and drop script video from Omogonix on Youtube - https://youtu.be/FnE4aS0dsE4?si=ire21gDw-Zz5evm2
* Change skybox script video from Cezary_Sharp on Youtube - https://www.youtube.com/watch?v=HAvHeIBVyvY
* Fire particle system references - [Video](https://youtu.be/PoMl09d1Avc?feature=shared) , [Unity Learn](https://learn.unity.com/tutorial/introduction-to-particle-systems#) , [Unity Docs](https://docs.unity3d.com/ScriptReference/ParticleSystem.html)

# What I am most proud of in the assignment
I am proud of the radio function. I think that it works really well and I am happy with the way the asset itself looks. I am also quite proud of the fire particle system. I like the colours and the low-poly arty style that it has. I think it fits the rest of the environment really well.

I am proud of what I was able to achieve by myself in the given amount of time for this project. I feel that I was able to execute the vision from my original proposal quite well and I was able to overcome most of the problems I encountered by myself along the way. Although I ultimately wasn't able to get the game working in VR in time for the submission I am stll very proud of how it turned out and I think that I learned a lot from doing this assignment that I can use to improve any future projects.

# What I learned
I learned a lot about sound design it Unity. I had never really done too much with game sounds until this project and I'm very happy with how they turned out. I will now be a lot more confident in adding sound affects and music to future projects and I also know how to make a volme controller and how to save and load the volume settings too.

I felt that I also learned a lot about particle systems in Unity. I'd never used them too much before as I found them very complicated and confusing, I had to learn how they worked so I could get the fire and smoke to look the way I wanted it to, luckily I was able to find a lot of material online to help with this (linked above). In the end, I found it really fun to learn how it all worked and as there are so many things you can do with particle systems, I look forward to getting the chance to use them again in future projects.

# Proposal submitted earlier can go here:
(Original proposal)

An interactive campfire experience with sounds, music and particle effects. I aim to make it so that you can change the colours of the fire and maybe even the effects too, as well as interact with the other objects in the environment, like roasting marshmallows and choosing some campfire songs to listen to!

# Image test:
