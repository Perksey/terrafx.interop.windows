// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct D3D_SHADER_MACRO
    {
        #region Fields
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("LPCSTR")]
        public sbyte* Definition;
        #endregion
    }
}
