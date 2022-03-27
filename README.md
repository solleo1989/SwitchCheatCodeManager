# Switch Cheat Code Manager

This application is written in C#, using .NET framework.

App was initially designed for Nintendo Switch cheats manipulation and management, cheats are basically used through Edizon(https://github.com/WerWolv/EdiZon) related RAM editing apps through RCM mode, such as Atmosphere(https://github.com/Atmosphere-NX/Atmosphere), SX OS and etc.

For here, I'd like to thank everyone who has ever contributed to this Switch customization community. 

It has a very common Windows GUI and easy to use. 
![image](https://user-images.githubusercontent.com/5420867/160268210-76a20aa6-76ce-4f81-9bca-520e98d08112.png)

# Functions
- Manage whole set of Switch cheats (under certain validation rules, not 100% correct. TODO)
- Add new set of cheats by providing Game name, Game ID (TID, i.e. 0100000000010000), Build ID (BID, i.e. B424BE150A8E7D78)
- Insert new cheat file by providing Build ID (BID, i.e. B424BE150A8E7D78) and Version (Version info, i.e. 1.3.0)
- Format all cheats file into a personal preferred standard (Capitalization)
- Format cheat contents into a standard format, remove redundant spaces and new lines characters.
- Support the new SubSection standards created by proferabg(https://github.com/proferabg/EdiZon-Overlay). Highly recommended, especially for lots of cheats scenario! (For detailed standards, please refer to his sites)
- Support the auto-scroll functions by selecting cheat title corresponding area in the cheats file.
- Display preview image for better looking and easy recognition.
  - Image file are located under each TID directory, i.e. "...\01003D200BAA2000\Pokemon Mystery Dungeon Rescue Team DX.jpg"
  - Image will be resized into 330x330, so better prepare a rectangle image.
- Support direct overwrite once you have the output path set (it will automatically detect the output Atmosphere path, or you can manually set in the config\settings.ini)

# Usage
1a. You can simply open a directory contains the folder of cheats, i.e.
-       ...\titles\...    (Set of cheats - 0100000000010000, 0100000011D90000, 010003F003A34000 ...)
-       ...\contents\...  (Set of cheats - 0100000000010000, 0100000011D90000, 010003F003A34000 ...)
1b. Or directly open a directory contains a single set of cheats, i.e.
-       ...\titles\0100ABF008968000\cheats
(NOTE: if you haven't set the default input folder, after the first open operation, it will automatically set this directory as you default directory. Thus, it will be easy to manage afterwards by click on the [DEFAULT] button. If you wanna change this default path, you are free to update the value under config/settings.ini)

2. Then you will see all the cheats under current path. Note: Single cheat mode may be restricted in several different functionalities.  

3. By select different games(TID) through the Dropdown list, you can traverse through different games. (Note: If the games has a description txt file under the directory, it will also show in the dropdown list for easy recognition.), such as:
>     010028600EBDA000 - Super Mario 3D World + Bowser's Fury
>     01002DA013484000 - The Legend of Zelda Skyward Sword HD
>     010003F003A34000 - Pokemon Let's Go, Pikachu!

4. After the game selected, you will see the corresponding cheats file listed in the left-bottom panel, you can simply choose anyone you want. (Note: if there's a BuildID - Version mapping in the description file, it will automatically show up.), such as:
>     B424BE150A8E7D78 (v1.3.0)
>     F5DCCDDB37E97724 (v1.2.0)
>     3CA12DFAAF9C82DA (v1.0.0)

5. After cheat build ID selected, cheats will be populated in the text field, you can simply change cheat contents and save it.
-     Cheats titles are grouped into "Cheat Sections", so you can use it as a navigation
      tool to position corresponding cheat entity in the cheat file.
-     If cheat has SubSection defined, it will be recognized as well. All subsections 
      will be shown in small sections, auto-scroll position function also supported.

6. If Output path(SDcard/FTP/drive path) has been set, you can directly overwrite single cheat or a set of cheats. (It will automatically detect each drive to find the Atmosphere contents folder.)


# Cheats Format
TBH, cheats contents do not have a standard form, and it's really hard for people to recognize through different game, different versions and etc.
Thus, I did a lot of customization on my set of cheats.

Here are some standards used within this application.

Cheats folder structure:
>     ..\0100ABF008968000\
>     ------ Pokemon Sword.txt    (This txt file name is the GAME NAME shown in the app. There's version mapping in txt, see below)
>     ------ Pokemon Sword.jpg    (This is the image file used to show in the app)
>     ------ cheats\
>     ---------- 5A7EEBF172343616.txt
>     ---------- 8DAFEDBB5BE81C2C.txt
>     ---------- 9D2DB721A9894075.txt
>     ... ...

Version mapping in directory txt file, i.e. "Pokemon Sword.txt". 
(Note: BID and Version are split by tab \t)
>       8DAFEDBB5BE81C2C	1.0.0
>       490648316CC1CCDC	1.1.0
>       9D2DB721A9894075	1.1.1
>       ... ...

# TODO
At this moment, this application is not well-designed and codes are not refactored, so it might be very buggy. 
Many cheat scenarios I probably haven't concerned, so the validation rules may be messed up. 
I will keep updating it until it becomes a well-accepted and commonly-use app.
