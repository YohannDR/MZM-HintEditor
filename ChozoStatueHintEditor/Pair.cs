using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozoStatueHintEditor
{
    public struct Pair
    {
        public Area AreaID1;
        public byte RoomID1;
        public byte MapX1;
        public byte MapY1;
        public Area AreaID2;
        public byte RoomID2;
        public byte MapX2;
        public byte MapY2;

        public Pair(Area areaID1, byte roomID1, byte mapX1, byte mapY1, Area areaID2, byte roomID2, byte mapX2, byte mapY2)
        {
            AreaID1 = areaID1;
            RoomID1 = roomID1;
            MapX1 = mapX1;
            MapY1 = mapY1;
            AreaID2 = areaID2;
            RoomID2 = roomID2;
            MapX2 = mapX2;
            MapY2 = mapY2;
        }

        public override string ToString()
            => $"{AreaID1} ; {RoomID1} ; {MapX1} ; {MapY1} ; {AreaID2} ; {RoomID2} ; {MapX2} ; {MapY2}";
    }
}
