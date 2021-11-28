# MZM-HintEditor

### Editor for the chozo statue hints of Metroid Zero Mission

## How To Use
Launch the program, then load your ROM (either will the button or by drag/dropping the file on the window)

### Hint Editor

![image](https://user-images.githubusercontent.com/81297939/143765748-cade6ed5-1dad-451f-ad34-473cb00d0b00.png)

You can select which hint you are ediing with the "Statue" list.

After that you can edit the starting point of the hint by editing the fields in the "Start" group box, this is where your statue is.
- Area : The area in which your statue is located
- Icon : Icon used for the entire path except the end
- X Position : X position on the minimap
- Y Position : Y position on the minimap
- X End : Not really sure what this is, i advise against editing it
- Y End : Not really sure what this is, i advise against editing it

You can then edit where your hint will end by editing the fields in the "target" group box.
- Area : The area in which your hint will go
- Icon : Icon used when your hint is at the target location
- X Position : X position on the minimap
- Y Position : Y position on the minimap

### Pair Editor

![image](https://user-images.githubusercontent.com/81297939/143765779-5caf972b-26f9-4aaa-8f9b-526bcb15b19e.png)

This allows you to edit the elevator room pairs, they are used by the hints to change the area

You can select which hint you are ediing with the "ID" list.

- Area 1 : The first area of the pair
- Area 2 : The second area of the pair
- Room ID 1 : The room ID in which the first elevator is located
- Room ID 2 : The room ID in which the second elevator is located
- Map X 1 : The X position on the minimap of the first elevator
- Map X 2 : The X position on the minimap of the second elevator
- Map Y 1 : The Y position on the minimap of the first elevator
- Map Y 2 : The Y position on the minimap of the second elevator

## Notes
- All numbers on the editor are in decimal, you may need to convert numbers if you are using MAGE
- Changes will be discarded if you change which hint/pair you are editing (they won't if you switch to the other editor)
- Clicking on the save button saves the current hint/pair on the current editor
- Report any bugs to me on Discord (either in MAGConst or by DM'ing me : yohann#2146)
