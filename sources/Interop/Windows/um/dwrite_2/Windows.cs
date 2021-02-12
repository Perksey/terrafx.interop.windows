// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IDWriteTextRenderer1 = new Guid(0xD3E0E934, 0x22A0, 0x427E, 0xAA, 0xE4, 0x7D, 0x95, 0x74, 0xB5, 0x9D, 0xB1);

        public static readonly Guid IID_IDWriteTextFormat1 = new Guid(0x5F174B49, 0x0D8B, 0x4CFB, 0x8B, 0xCA, 0xF1, 0xCC, 0xE9, 0xD0, 0x6C, 0x67);

        public static readonly Guid IID_IDWriteTextLayout2 = new Guid(0x1093C18F, 0x8D5E, 0x43F0, 0xB0, 0x64, 0x09, 0x17, 0x31, 0x1B, 0x52, 0x5E);

        public static readonly Guid IID_IDWriteTextAnalyzer2 = new Guid(0x553A9FF3, 0x5693, 0x4DF7, 0xB5, 0x2B, 0x74, 0x80, 0x6F, 0x7F, 0x2E, 0xB9);

        public static readonly Guid IID_IDWriteFontFallback = new Guid(0xEFA008F9, 0xF7A1, 0x48BF, 0xB0, 0x5C, 0xF2, 0x24, 0x71, 0x3C, 0xC0, 0xFF);

        public static readonly Guid IID_IDWriteFontFallbackBuilder = new Guid(0xFD882D06, 0x8ABA, 0x4FB8, 0xB8, 0x49, 0x8B, 0xE8, 0xB7, 0x3E, 0x14, 0xDE);

        public static readonly Guid IID_IDWriteFont2 = new Guid(0x29748ED6, 0x8C9C, 0x4A6A, 0xBE, 0x0B, 0xD9, 0x12, 0xE8, 0x53, 0x89, 0x44);

        public static readonly Guid IID_IDWriteFontFace2 = new Guid(0xD8B768FF, 0x64BC, 0x4E66, 0x98, 0x2B, 0xEC, 0x8E, 0x87, 0xF6, 0x93, 0xF7);

        public static readonly Guid IID_IDWriteColorGlyphRunEnumerator = new Guid(0xD31FBE17, 0xF157, 0x41A2, 0x8D, 0x24, 0xCB, 0x77, 0x9E, 0x05, 0x60, 0xE8);

        public static readonly Guid IID_IDWriteRenderingParams2 = new Guid(0xF9D711C3, 0x9777, 0x40AE, 0x87, 0xE8, 0x3E, 0x5A, 0xF9, 0xBF, 0x09, 0x48);

        public static readonly Guid IID_IDWriteFactory2 = new Guid(0x0439FC60, 0xCA44, 0x4994, 0x8D, 0xEE, 0x3A, 0x9A, 0xF7, 0xB7, 0x32, 0xEC);
    }
}
