﻿using System.IO;

namespace SanAndreasUnity.Importing.Collision
{
    public class Box
    {
        public readonly Vector3 Min;
        public readonly Vector3 Max;
        public readonly Surface Surface;

        public Box(BinaryReader reader, Version version)
        {
            Min = new Vector3(reader);
            Max = new Vector3(reader);
            Surface = new Surface(reader);
        }
    }
}
