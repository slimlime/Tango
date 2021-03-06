﻿using ProtoBuf;
using UnityEngine;

namespace CSM.Commands
{
    [ProtoContract]
    public class BuildingRelocateCommand : CommandBase
    {
        [ProtoMember(1)]
        public Vector3 NewPosition { get; set; }

        [ProtoMember(2)]
        public Vector3 OldPosition { get; set; }

        [ProtoMember(3)]
        public float Angle { get; set; }
    }
}