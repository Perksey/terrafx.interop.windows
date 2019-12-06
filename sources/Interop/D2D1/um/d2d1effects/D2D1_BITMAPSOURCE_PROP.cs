// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_BITMAPSOURCE_PROP : uint
    {
        D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE = 0,
        D2D1_BITMAPSOURCE_PROP_SCALE = 1,
        D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE = 2,
        D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION = 3,
        D2D1_BITMAPSOURCE_PROP_ALPHA_MODE = 4,
        D2D1_BITMAPSOURCE_PROP_ORIENTATION = 5,
        D2D1_BITMAPSOURCE_PROP_FORCE_DWORD = 0xffffffff,
    }
}
