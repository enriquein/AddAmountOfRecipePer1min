# AddAmountOfRecipePer1minContinued

This mod adds amount of recipe per 1min in ItemTip GUI.

Note: The original developer seems to have halted updates to this mod and I have taken up
maintenance for future updates. If at any point the original developer returns, I will gladly
remove this version and fall back to theirs. I take no credit for the work done on this mod,
save for a few minor tweaks and making sure it runs without errors in future versions. All rights
and credit goes to `wokdok` for making this awesome mod that I can't play without.

## Sample

![sample](https://github.com/wokdok/AddAmountOfRecipePer1min/blob/master/sample.png?raw=true "sample")

## Configuration

This mod allows configuration of the default speeds for assemblers and smelters. It also allows you to specify which speeds to
display if you hold certain keys while hovering over an item. To set the configuration values, please remember that you need to run the
game once before the configuration file will be generated. Afterwards, you may use the r2modman configuration editor to change the values.
The available configuration values are:

- `Default_Assembler_Speed`: The default assembler speed to use for tooltips. Valid values are `mk1`, `mk2`, and `mk3`. The default is `mk2`.
- `Default_Smelter_Speed`: The default smelter speed to use for tooltips. Valid values are `mk1` and `mk2`. The default is `mk1`.
- `Limit_Default_Assembler_Speed_To_Latest_Unlocked`: When `true` it will limit the default speed to the maximum assembler speed unlocked. Useful if you want to display a specific
  speed, but only if you have unlocked it. If `false` it will always use the default speed regardless of your unlocks.
- `Limit_Default_Smelter_Speed_To_Latest_Unlocked`: When `true` it will limit the default speed to the maximum smelter speed unlocked. Useful if you want to display a specific
  speed, but only if you have unlocked it. If `false` it will always use the default speed regardless of your unlocks.
- `Speed_To_Show_On_Left_Ctrl`: Speed to show when pressing the left `Ctrl` key while hovering over an item. Valid values are `mk1`, `mk2`, and `mk3`.
  Only applies to Assemblers, since Smelters will use the non-default speed on hover.
- `Speed_To_Show_On_Left_Shift`: Speed to show when pressing the left `Shift` key while hovering over an item. Valid values are `mk1`, `mk2`, and `mk3`. Only applies to
  Assemblers, since Smelters will use the non-default speed on hover.
- `Speed_To_Show_On_Left_Alt`: Speed to show when pressing the left `Alt` key while hovering over an item. Valid values are `mk1`, `mk2`, and `mk3`. Only applies to Assemblers,
  since Smelters will use the non-default speed on hover.

## ChangeLog

### 1.2.4
* Added the ability to configure the default speed, and also the speed to show when holding keys while hovering. Use r2modman's config editor to set the values.
    * The default configuration values are the same that were being used in previous versions.
      This means that if you liked the previous behavior then you don't need to change anything.

### 1.2.3
* Added support for the Plane Smelter in tooltips. Hold any of left: `ctrl`, `shift`, or `alt` to display Plane Smelter speeds.
    * Does not require to have unlocked Plane Smelter in the tech tree for it to work.

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
