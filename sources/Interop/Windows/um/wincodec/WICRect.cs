// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct WICRect
    {
        #region Fields
        [NativeTypeName("INT")]
        public int X;

        [NativeTypeName("INT")]
        public int Y;

        [NativeTypeName("INT")]
        public int Width;

        [NativeTypeName("INT")]
        public int Height;
        #endregion
    }
}
