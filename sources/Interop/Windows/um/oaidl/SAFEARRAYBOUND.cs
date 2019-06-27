// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct SAFEARRAYBOUND
    {
        #region Fields
        [NativeTypeName("ULONG")]
        public uint cElements;

        [NativeTypeName("LONG")]
        public int lLbound;
        #endregion
    }
}
