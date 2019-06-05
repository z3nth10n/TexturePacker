﻿using System;

namespace TexturePacker.Lib
{
    /// <summary>
    /// Represents a Texture in an atlas
    /// </summary>
    [Serializable]
    public sealed class TextureInfo
    {
        /// <summary>
        /// Path of the source texture on disk
        /// </summary>
        public string Source;

        /// <summary>
        /// Width in Pixels
        /// </summary>
        public int Width;

        /// <summary>
        /// Height in Pixels
        /// </summary>
        public int Height;
    }
}