// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct WICMetadataPattern
    {
        #region Fields
        public ULARGE_INTEGER Position;

        [NativeTypeName("ULONG")]
        public uint Length;

        [NativeTypeName("BYTE[]")]
        public byte* Pattern;

        [NativeTypeName("BYTE[]")]
        public byte* Mask;

        public ULARGE_INTEGER DataOffset;
        #endregion
    }
}
