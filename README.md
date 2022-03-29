# Switch Cheat Code Manager

This application is written in **C#**, using **.NET framework**.

App was initially designed for **Nintendo Switch** cheats manipulation, organization and management. 

Cheats are basically used through **Edizon** (_<https://github.com/WerWolv/EdiZon>_) related RAM editing apps through RCM mode, such as **Atmosphere**(_<https://github.com/Atmosphere-NX/Atmosphere>_), SX OS and etc.

For here, I'd like to thank everyone who has ever contributed to this Switch customization community.

It has a very common Windows GUI and easy to use.
![image](https://user-images.githubusercontent.com/5420867/160268210-76a20aa6-76ce-4f81-9bca-520e98d08112.png)

## Features

---

- Manage whole set of Switch cheats (under certain validation rules, _not 100% correct_. **TODO**)
- Add new _set of cheats_ by providing
  - Game name (i.e., `Super Mario Odyssey`)
  - Game ID - **TID** (i.e., `0100000000010000`)
  - Build ID - **BID** (i.e., `B424BE150A8E7D78`)
- Insert new _cheat file_ by providing
  - Build Id - **BID** (i.e., `B424BE150A8E7D78`) and
  - Version Numer (i.e., `1.3.0`)
- Format each _cheats file_ into a personal preferred standard (**CAPITALIZATION**)
- Format cheat contents into a standard format: _remove redundant spaces and new lines characters_.
- Support the new SubSection standards created by **proferabg**(_<https://github.com/proferabg/EdiZon-Overlay>_). **Highly recommended**, especially for lots of cheats scenarios! (_For detailed information, please refer to his site._)
- Support auto-scroll function: selecting _cheat title_ (i.e., `[Inf Health (ON)]`) will scroll to corresponding area in the cheats file.
- Display preview image for better looking and easy recognition.
  - Image file is located under each TID directory (i.e., `...\01003D200BAA2000\Pokemon Mystery Dungeon Rescue Team DX.jpg`)
  - Image will be resized into **350x350**, so better to prepare a rectangle image, or it might be streached.
- Support direct overwrite once you have the _output path_ set
  - It will automatically detect the output **Atmosphere** directory
  - Or you can manually set `[output_folder]` in the "`config\settings.ini`"

## Usage

---

1. [`List-Cheat mode`]: Open a directory contains the _folder of cheats_, i.e.,

   > _It's always to **recommended** to have a single folder to preserve your own cheats instead of copy-paste a whole bunch of cheats set from SwitchDB or somewhere else. It may not pass the validation rules through my app._

    - (**`SX OS`**) **...\titles\\...**     {Set of cheats: 0100000000010000, 0100000011D90000, 010003F003A34000 ...}
    - (**`Atmosphere`**) **...\contents\\...**{Set of cheats: 0100000000010000, 0100000011D90000, 010003F003A34000 ...}

    [`Single-Cheat mode`]: Open a directory contains a single _set of cheats_, i.e.,

    - (**`SX OS`**) **...\titles\0100ABF008968000\cheats**
    - (**`Atmosphere`**) **...\contents\0100ABF008968000\cheats**

    > If you haven't set the default `[input_folder]`, after the first **OPEN** operation, it will automatically set **this directory** as you default `input_folder`. As a result, it will be easy to manage afterwards, by clicking on the `[DEFAULT]` button.
    >>  _If you want to change the default `[input_folder]`, you can update this value in "`config\settings.ini`"_

2. Then you will see all the cheats under current directory, and you are able to process cheats based on the Features provided.
   > `Single-Cheat mode` may be restricted in several different functionalities.  

3. By selecting different games (**TID**s) through the _dropdown list_, you can traverse through different games.
    - Note: If there's a _`[description].txt`_ file under the game directory, the name _`[description]`_ will also show in the dropdown list for easy recognition. For example:

    >     010028600EBDA000 - Super Mario 3D World + Bowser's Fury
    >     01002DA013484000 - The Legend of Zelda Skyward Sword HD
    >     010003F003A34000 - Pokemon Let's Go, Pikachu!

4. Once a game (**TID**) is selected through the _dropdown list_, you will see the corresponding cheats (**BID**s) listed in the left-bottom panel. You can simply choose among these cheats.
    - Note: if there's a `BuildID - Version` mapping in the _`[description].txt`_ file, it will automatically pick up. For eaxample:

    >     B424BE150A8E7D78 (v1.3.0)
    >     F5DCCDDB37E97724 (v1.2.0)
    >     3CA12DFAAF9C82DA (v1.0.0)
    - Otherwise, they will display as
    >     B424BE150A8E7D78
    >     F5DCCDDB37E97724
    >     3CA12DFAAF9C82DA

5. After a cheat (**BID**) is selected through the _comobox_, correspongding _cheat contents_ will be populated in the _text area_ panel. You can simply modify any cheat contents and save afterwards.

    - _`Cheat titles`_ are grouped and divided into "**Cheat Sections**". You can use it as a _navigation
      tool_ to position corresponding _`cheat title`_ across the cheat file.

    - If a cheat has **`[SubSection]`** defined, it will be recognized in "**Cheat Sections**" as well. All **`SubSection`s** will be shown in small sections, and _auto-scroll positioning_ function is also supported.

6. If **Output path** (from SDcard/FTP/Drive) has been set, you can directly overwrite single cheat or a folder of cheats.
    > It will automatically detect each drive and find the **Atmosphere** contents folder.

## Format

---

TBH, cheat contents **do not** have a _standard form_. It's really hard for different people to manage through different games, different versions and etc.
Thus, I did a lot of customizations on my set of cheats per using this application.

Here are some formating standards applied within this application.:

### Cheats folder structure

>     ..\0100ABF008968000\
>       ------ Pokemon Sword.txt    (A txt file describe [GAME NAME] shown in the app. There's also a BID-Version mapping written in the txt, detail format see below.)
>       ------ Pokemon Sword.jpg    (An image file used to show in the app.)
>       ------ cheats\              (A cheats folder.)
>       ---------- 5A7EEBF172343616.txt
>       ---------- 8DAFEDBB5BE81C2C.txt
>       ---------- 9D2DB721A9894075.txt
>       ... ...
>       ---------- A3B75BCD3311385A.txt

### BuildID-Version mapping structure

- Written in the _`[GAME NAME].txt`_  file, i.e., "_`Pokemon Sword.txt`_"

>     8DAFEDBB5BE81C2C  1.0.0
>     490648316CC1CCDC  1.1.0
>     9D2DB721A9894075  1.1.1
>     5A7EEBF172343616  1.2.0
>     ... ...
>     A3B75BCD3311385A  1.3.2

- Note: BID and Version are split by tab `\t`

## TODO

---

At this moment, this application is _**not well-designed**_ and codes are _**not refactored**_, so it might be very buggy through frequent uses.  

Obviously, many cheat code scenarios I probably **haven't concerned and covered** yet, the current validation rules and formatting logics may mess your cheats up.

**MENTION: Use at Your Own Risk !!!**

I will keep updating it until it becomes a well-accepted and commonly-use app.
