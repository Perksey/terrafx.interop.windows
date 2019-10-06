// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The DWRITE_GLYPH_RUN_DESCRIPTION public partial structure contains additional properties related to those in DWRITE_GLYPH_RUN.</summary>
    public unsafe partial struct DWRITE_GLYPH_RUN_DESCRIPTION
    {
        /// <summary>The locale name associated with this run.</summary>
        [NativeTypeName("WCHAR[]")]
        public ushort* localeName;

        /// <summary>The text associated with the glyphs.</summary>
        [NativeTypeName("WCHAR[]")]
        public ushort* @string;

        /// <summary>The number of characters (UTF16 code-units). Note that this may be different than the number of glyphs.</summary>
        [NativeTypeName("UINT32")]
        public uint stringLength;

        /// <summary>An array of indices to the glyph indices array, of the first glyphs of all the glyph clusters of the glyphs to render.</summary>
        [NativeTypeName("UINT16[]")]
        public ushort* clusterMap;

        /// <summary>Corresponding text position in the original string this glyph run came from.</summary>
        [NativeTypeName("UINT32")]
        public uint textPosition;
    }
}
