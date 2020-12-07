﻿using MessagePack;
using UnityEngine;

namespace Dungeoneer.Netowrking.Packets
{
    [MessagePackObject]
    public struct CharacterPacket
    {
        [Key(0)]
        public Vector2 Pos { get; set; }
    }

}
