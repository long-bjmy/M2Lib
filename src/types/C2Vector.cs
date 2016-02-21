﻿using System.IO;
using m2lib_csharp.interfaces;

namespace m2lib_csharp.types
{
    /// <summary>
    /// A two component float vector.
    /// </summary>
    public class C2Vector : IMarshalable
    {
        public float X, Y;

        public C2Vector(float p1 = 0, float p2 = 0)
        {
            X = p1;
            Y = p2;
        }

        public void Load(BinaryReader stream, int version = -1)
        {
            X = stream.ReadSingle();
            Y = stream.ReadSingle();
        }

        public void Save(BinaryWriter stream, int version = -1)
        {
            stream.Write(X);
            stream.Write(Y);
        }
    }
}