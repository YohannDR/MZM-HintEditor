using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozoStatueHintEditor
{
    public enum Icon
    {
        Target = 0x1,
        UpElevator = 0x2,
        DownElevator = 0x3,
        GreenFlame = 0x8,
        GreenFlameMoving = 0xA,
        PinkFlame = 0xC,
        PinkFlameMoving = 0xE
    }

    public enum Area
    {
        Brinstar,
        Kraid,
        Norfair,
        Ridley,
        Tourian,
        Crateria,
        Chozodia
    }

    public struct Path
    {
        public Area StartArea;
        public byte XStart;
        public byte XEnd;
        public byte YStart;
        public byte YEnd;
        public Icon StartIcon;
        public Area TargetArea;
        public byte XTarget;
        public byte YTarget;
        public Icon TargetIcon;

        public Path(Area startArea, byte xStart, byte xEnd, byte yStart, byte yEnd, Icon startIcon, Area targetArea, byte xTarget, byte yTarget, Icon targetIcon)
        {
            StartArea = startArea;
            XStart = xStart;
            XEnd = xEnd;
            YStart = yStart;
            YEnd = yEnd;
            StartIcon = startIcon;
            TargetArea = targetArea;
            XTarget = xTarget;
            YTarget = yTarget;
            TargetIcon = targetIcon;
        }

        public static byte IconToIndex(Icon icon)
        {
            return icon switch
            {
                Icon.Target => 0,
                Icon.UpElevator => 1,
                Icon.DownElevator => 2,
                Icon.GreenFlame => 3,
                Icon.GreenFlameMoving => 4,
                Icon.PinkFlame => 5,
                Icon.PinkFlameMoving => 6,
                _ => 0
            };
        }

        public static Icon IndexToIcon(int index)
        {
            return index switch
            {
                0 => Icon.Target,
                1 => Icon.UpElevator,
                2 => Icon.DownElevator,
                3 => Icon.GreenFlame,
                4 => Icon.GreenFlameMoving,
                5 => Icon.PinkFlame,
                6 => Icon.PinkFlameMoving,
                _ => Icon.Target
            };
        }

        public override string ToString()
            => $"{StartArea} ; {XStart} ; {XEnd} ; {YStart} ; {YEnd} ; {StartIcon} ; {TargetArea} ; {XTarget} ; {YTarget} ; {TargetIcon}";
    }
}
