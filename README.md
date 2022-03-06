# AddAmountOfRecipePer1minContinued

This mod adds amount of recipe per 1min in ItemTip GUI.

Note: The original developer seems to have halted updates to this mod and I have taken up
maintenance for future updates. If at any point the original developer returns, I will gladly
remove this version and fall back to theirs. I take no credit for the work done on this mod,
save for a few minor tweaks and making sure it runs without errors in future versions. All rights
and credit goes to `wokdok` for making this awesome mod that I can't play without.

## Sample

![sample](https://github.com/wokdok/AddAmountOfRecipePer1min/blob/master/sample.png?raw=true "sample")

## ChangeLog

### 1.2.3
* Added support for the Plane Smelter in tooltips. Hold any of left: `ctrl`, `shift`, or `alt` to display Plane Smelter speeds.
    * Does not require to have unlocked Plane Smelter in the tech tree for it to work.
    * There's a known issue with the display of the Organic Crystal and Crystal Silicon recipes, where the second recipe always shows in Plane Smelter speed.
      Use the keyboard modifiers to display regular Smelter speeds until I can figure out why this is.

### 1.2.2
* maximum default assembler speed is now limited to mk2 even if mk3 is unlocked (to keep it nice at 100% speed by default, if mk2 unlocked).
* add ability to switch the displayed speed on the fly by holding left `ctrl`, `shift` or `alt` while hovering over the item:
    * `left ctrl` = mk1
    * `left shift` = mk2
    * `left alt` = mk3
* fix error when running the latest DSP version.

### 1.2.1
* fix error when hover over the coal recipe.

### 1.2.0
* add amount of transport speed per 1min to belt recipe.
* refactoring

### 1.1.1
* fix error when hover over the deuterium recipe.

### 1.1.0
* If the recipe uses Assembler, calculate with the most powerful Assembler.（mk3＞mk2>mk1)

### 1.0.1
* fix sample.png location

### 1.0.0
* initial release
